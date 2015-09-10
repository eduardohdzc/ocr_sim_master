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
     private string language;
     public TesseractWrapper()
        {
            outputText = "Not Recognized";
            language = "eng";
        }

     public string getTextFromImageFile(string filePath, Language selectedLanguage,  string selectedMode)
     {
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


         createTesseract(filePath);
            
     }

     private void createTesseract(string fileName)
     {
         // To DO, Bitmap not recognized
         Bitmap image = new Bitmap(fileName);
         Tesseract.TesseractEngine engine = new TesseractEngine(@"./tessdata", "eng", EngineMode.Default);
            Tesseract.Page page = engine.Process(image);
            

            outputText = page.GetText();
         Console.WriteLine(outputText);
         engine.Dispose();         
     }
    }
}
