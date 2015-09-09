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

     public string getTextFromImageFile(string filePath, string selectedLanguage, string selectedMode)
     {
         switch (selectedLanguage)
         {
             case "SPANISH":
                 language = "spa";
                 break;
             case "ENGLISH":
                 language = "eng";
                 break;
             case "GERMAN":
                 language = "deu";
                 break;
             case "CHINESE_SIMPLIFIED":
                 language = "chi_sim";
                 break;
             default:
                 language = "eng";
                 break;

         }

         createTesseract(filePath);

         throw new NotImplementedException();
     }
     private void createTesseract(string fileName)
     {
         // To DO, Bitmap not recognized
         //Bitmap image = new Bitmap(fileName);
         Tesseract.TesseractEngine engine = new TesseractEngine(@"./tessdata", "eng", EngineMode.Default);
         //Tesseract.Page page = engine.Process(image);
         outputText = page.GetText();
         Console.WriteLine(outputText);
         engine.Dispose();
         throw new NotImplementedException();

     }
    }
}
