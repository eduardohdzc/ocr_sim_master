using Ocr.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using asprise_ocr_api;

namespace Ocr.Wrapper.Asprise
{
    public class AspriseWrapper : IOcrEngine
    {
        public string getTextFromImageFile(string filePath, Language selectedLanguage, string selectedMode)
        {

            string language = AspriseOCR.LANGUAGE_ENG;
            switch (selectedLanguage)
            {
                case Language.SPANISH:
                    language = AspriseOCR.LANGUAGE_SPA;
                    break;
                case Language.ENGLISH:
                    language = AspriseOCR.LANGUAGE_ENG;
                    break;
                case Language.GERMAN:
                    language = AspriseOCR.LANGUAGE_DEU;
                    break;
                default:
                    language = AspriseOCR.LANGUAGE_ENG;
                    break;
            }
                    
            AspriseOCR.SetUp();           
            
            AspriseOCR ocr = new AspriseOCR();           

            ocr.StartEngine(language, AspriseOCR.SPEED_FASTEST);

            string s = ocr.Recognize(filePath, -1, -1, -1, -1, -1, AspriseOCR.RECOGNIZE_TYPE_ALL, AspriseOCR.OUTPUT_FORMAT_PLAINTEXT);
            
            ocr.StopEngine();

            return s;
        }
    }
}
