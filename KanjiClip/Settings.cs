using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KanjiClip
{
    public partial class Settings : Form
    {
        private readonly Configuration config = null;

        public Settings(Configuration config)
        {
            InitializeComponent();

            this.config = config;

            // Load config keys
            imgBBKey.Text = config.AppSettings.Settings["IMGBB_APIKEY"].Value;
            nanoGPTApiKey.Text = config.AppSettings.Settings["NANOGPT_APIKEY"].Value;
            nanoGPTBaseUrl.Text = config.AppSettings.Settings["API_URL"].Value;
        }

        private void SaveSettings(object sender, EventArgs e)
        {
            // Set new config values
            config.AppSettings.Settings["IMGBB_APIKEY"].Value = imgBBKey.Text;
            config.AppSettings.Settings["NANOGPT_APIKEY"].Value = nanoGPTApiKey.Text;
            config.AppSettings.Settings["API_URL"].Value = nanoGPTBaseUrl.Text;

            config.Save(ConfigurationSaveMode.Modified);

            MessageBox.Show("Settings applied and saved.", Form1.AppName, MessageBoxButtons.OK, MessageBoxIcon.Information);

            ConfigurationManager.RefreshSection("appSettings");

            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void Close(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
