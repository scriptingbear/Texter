using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Texter
{
    public partial class frmTexter : Form
    {
        public frmTexter()
        {
            InitializeComponent();
        }

        private void selectFont_Click(object sender, EventArgs e)
        {
            if (fontSelector.ShowDialog() == DialogResult.OK) {
                twistedText.Font = fontSelector.Font;
               
            }
        }

       

        private void twistedText_TextChanged(object sender, EventArgs e)
        {
            var twisted_text = inputText.Text;
            if (twisted_text == string.Empty) return;
            
            twisted_text = trimInput(twisted_text);
            twisted_text = setCase(twisted_text);
            twisted_text = reverseText(twisted_text);
            twisted_text = setMinWordLength(twisted_text);

            twistedText.Text = twisted_text;



        }//twistedText_TextChanged()

        private string trimInput(string text)
        {
            if (trimExternalBlanks.Checked)
                text = text.Trim();

            if (trimInternalBlanks.Checked)
                text = Regex.Replace(text, @"\s{2,}", " ");

            return text;
    
        }//trimInput

        private string setCase(string text)
        {
            CultureInfo culture = Thread.CurrentThread.CurrentCulture;
            TextInfo text_info = culture.TextInfo;

            if (convertUpper.Checked)
                return text.ToUpper();
            else if (convertLower.Checked)
                return text.ToLower();
            else if (convertProper.Checked)
                return text_info.ToTitleCase(text);
            else
                return text;
           

        }//setCase()

        private string reverseText(string text)
        {
            if (reverseChars.Checked)
                return new string(text.ToCharArray().Reverse().ToArray());

            else if (reverseWords.Checked)
            {
                string[] word_array = text.Split(' ');
                return string.Join(" ", word_array.Reverse());
            }
            else
                return text;

        }//reverseText()

        private string setMinWordLength(string text)
        {
            if (minWordLength.Value == 0)
                return text;
            else
            {
                var word_array = text.Split(' ');
                var query = from word in word_array
                            where word.Length >= minWordLength.Value select word;

                return string.Join(" ", query);

            }

        }//setMinWordLength()

    }//frmTexter: Form
}//Texter
