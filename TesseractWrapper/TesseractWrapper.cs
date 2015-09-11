using Ocr.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tesseract;

namespace Ocr.Wrapper.TesseractWrapper
{
    public class TesseractWrapper : IOcrEngine
    {
        private string outputText;
        

        public TesseractWrapper()
        {
            outputText = "Not Recognized";            
        }

     public string getTextFromImageFile(string filePath, Language selectedLanguage,  string selectedMode)
     {
             string language = "eng";
             switch (selectedLanguage)
             {
                 case Language.SPANISH:
                     language = "spa";
                     break;
                 case Language.ENGLISH:
                     language = "eng";
                     break;
                    case Language.GERMAN:
                     language = "deu";
                     break;            
                 default:
                     language = "eng";
                     break;
             }

            try {
                Bitmap image = new Bitmap(filePath);

                Tesseract.TesseractEngine engine = new TesseractEngine(@"C:\Users\Luis\Source\Repos\ocr_sim_master\TesseractWrapper\tessdata",
                    language, EngineMode.Default);
                Tesseract.Page page = engine.Process(image);

                outputText = page.GetText();

                engine.Dispose();
            } catch (Exception e)
            {
                outputText = "An error occurred, the file is not an image: \n\n" + e.ToString();
            }
           
            return outputText;

        }    
    }
}
