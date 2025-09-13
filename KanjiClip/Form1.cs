using System;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace KanjiClip
{
    public partial class Form1 : Form
    {
        public const string AppName = "KanjiClip";

        private readonly AnkiConnect ankiConnect = new AnkiConnect();
        private readonly Configuration config = null;

        private ImgBB imgBB = null;
        private NanoGPTClient nanoGPTClient = null;

        private bool processing = false;

        public Form1()
        {
            InitializeComponent();

            this.DoubleBuffered = true;
            this.KeyPreview = true;

            this.config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            
            var appSettings = new string[]{ "IMGBB_APIKEY", "NANOGPT_APIKEY", "API_URL" };
            bool flag = false;
            foreach (var item in appSettings)
            {
                if (config.AppSettings.Settings[item] == null || config.AppSettings.Settings[item].Value.Length == 0)
                {
                    flag = true;
                    break;
                }
            }

            // If any config keys are missing, open settings
            if (!flag)
            {
                this.imgBB = new ImgBB(config.AppSettings.Settings["IMGBB_APIKEY"].Value);
                this.nanoGPTClient = new NanoGPTClient(config.AppSettings.Settings["NANOGPT_APIKEY"].Value, config.AppSettings.Settings["API_URL"].Value);
            }
            else MessageBox.Show("One or more configuration keys are missing. Please set them in the settings menu.", AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private async void FormLoaded(object sender, EventArgs e)
        {
            while (!Utils.IsAnkiRunning())
            {
                DialogResult r = MessageBox.Show("Anki is not running. Please start Anki and continue", AppName, MessageBoxButtons.RetryCancel);
                if (r == DialogResult.Cancel)
                {
                    Application.Exit();
                    return;
                }
            }

            bool openedOnce = false;
            while (!await ankiConnect.IsAnkiConnectPresent())
            {
                DialogResult r = MessageBox.Show("AnkiConnect is not present. Please install AnkiConnect from https://ankiweb.net/shared/info/2055492159 and try again.", AppName, MessageBoxButtons.RetryCancel);
                if (r == DialogResult.Cancel)
                {
                    Application.Exit();
                    return;
                }

                if (!openedOnce)
                {
                    openedOnce = true;
                    Process.Start("https://ankiweb.net/shared/info/2055492159");
                }
            }

            deckBox.Items.Clear();
            deckBox.Items.AddRange((await ankiConnect.GetDecks()).ToArray());
            deckBox.SelectedIndex = 0;
        }

        private void FormKeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode == Keys.V)
            {
                e.Handled = true;
                FlatButton1_Click(sender, e);
            }
        }

        private void FlatButton1_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsImage())
            {
                if (processing) return;
                if (label.Visible) label.Visible = false;

                processing = true;
                progressBar.Value = 25;
                status.Text = "Uploading image to ImgBB...";

                var image = Clipboard.GetImage();

                picture.BringToFront();
                picture.Image = image;

                ProcessImage(image);

                return;
            }

            MessageBox.Show("Clipboard does not contain an image.");
        }

        private void ResetProgress()
        {
            processing = false;
            progressBar.Value = 0;
            status.Text = "Idle";
        }

        private async void ProcessImage(Image img)
        {
            var url = await imgBB.UploadPhoto(img);
            if (url == null)
            {
                MessageBox.Show("Failed to upload image to ImgBB.", AppName);
                ResetProgress();
                return;
            }

            progressBar.Value = 50;
            status.Text = "Asking AI... (be patient)";

            var result = await this.nanoGPTClient.Translate(url);
            if (result == null || string.IsNullOrWhiteSpace(result.Kanji) || string.IsNullOrWhiteSpace(result.Translation) || string.IsNullOrWhiteSpace(result.Romaji))
            {
                MessageBox.Show("Failed to get a valid response from the AI.", AppName);
                ResetProgress();
                return;
            }

            progressBar.Value = 75;
            status.Text = "Adding note to Anki...";

            // Show AddToAnki dialog
            var window = new AddToAnki(this.ankiConnect, this.deckBox, result);
            window.FormClosed += (o, e) => ResetProgress();

            window.ShowDialog(this);
        }

        private void SettingsClick(object sender, EventArgs e)
        {
            Settings settings = new Settings(this.config);
            var result = settings.ShowDialog(this);
            if(result == DialogResult.OK)
            {
                this.imgBB = new ImgBB(config.AppSettings.Settings["IMGBB_APIKEY"].Value);
                this.nanoGPTClient = new NanoGPTClient(config.AppSettings.Settings["NANOGPT_APIKEY"].Value, config.AppSettings.Settings["API_URL"].Value);
            }

        }
    }
}
