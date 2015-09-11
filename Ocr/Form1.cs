using Ocr.Engine;
using Ocr.Engine.Handler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ocr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void readTextFromImage()
        {
            resultBox.Text = "";
            if (filePath.Text.Equals(""))
            {
                resultBox.Text = "Select an image.";
            }
            else
            {
                // Llamar factory abstract:
                IOcrEngine ocrEngine = OcrEngineHandler.createEngine(engineBox.Text);

                Language lang = Language.ENGLISH;
                if (languageBox.Text.Equals("ENGLISH"))
                {
                    lang = Language.ENGLISH;
                }
                else if (languageBox.Text.Equals("SPANISH"))
                {
                    lang = Language.SPANISH;
                }
                else if (languageBox.Text.Equals("GERMAN"))
                {
                    lang = Language.GERMAN;
                }
                else if (languageBox.Text.Equals("FRENCH"))
                {
                    lang = Language.FRENCH;
                }

                string result = ocrEngine.getTextFromImageFile(filePath.Text, lang, "");
                resultBox.Text = result;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Fachada
            readTextFromImage();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                filePath.Text = openFileDialog1.FileName;
                pictureBox1.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void engineBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (engineBox.Text.Equals("MODI"))
            {
                languageBox.Items.Clear();
                languageBox.Items.Add("ENGLISH");
                languageBox.Items.Add("FRENCH");
                languageBox.Items.Add("SPANISH");
            }
            else if (engineBox.Text.Equals("Tesseract"))
            {
                languageBox.Items.Clear();
                languageBox.Items.Add("ENGLISH");
                languageBox.Items.Add("GERMAN");
                languageBox.Items.Add("SPANISH");
            }
            else if (engineBox.Text.Equals("Asprise"))
            {
                languageBox.Items.Clear();
                languageBox.Items.Add("ENGLISH");
      
            }

            languageBox.SelectedIndex = 0;
        }
    }
}