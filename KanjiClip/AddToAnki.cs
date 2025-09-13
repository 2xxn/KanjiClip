using FlatUI;
using KanjiClip.AnkiConnectTypes;
using MyNihongo.KanaConverter;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace KanjiClip
{
    public partial class AddToAnki : Form
    {
        private readonly AnkiConnect client;
        private readonly string deck;

        public AddToAnki(AnkiConnect client, FlatComboBox decks, TranslationResponse t)
        {
            InitializeComponent();

            flatComboBox1.Items.Clear();
            flatComboBox1.Items.AddRange(decks.Items.Cast<string>().ToArray());
            flatComboBox1.SelectedIndex = decks.SelectedIndex;

            this.client = client;
            this.deck = (string)decks.Items[decks.SelectedIndex];

            kanji.Text = t.Kanji;
            hiragana.Text = t.Romaji.ToLower().ToHiragana(UnrecognisedCharacterPolicy.Append);
            meaning.Text = t.Translation;
        }

        private async void AddCard(object sender, EventArgs e)
        {
            var success = await this.client.AddNote(new Note
            {
                DeckName = this.deck,
                ModelName = "Basic",
                NoteFields = new Fields{
                    Front = kanji.Text,
                    Back = $"<center>{hiragana.Text}<br><small style=\"color: red\">{meaning.Text}</small></center>"
                },
                Tags = new List<string> { Form1.AppName }
            });

            if (success)
            {
                Close();
                return;
            }

            MessageBox.Show("Failed to add note to Anki", Form1.AppName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Cancel(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
