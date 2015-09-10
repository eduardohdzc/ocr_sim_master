using Ocr.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocr.Wrapper.ModiWrapper
{
    public class ModiWrapper : IOcrEngine
    {
        private string outputText;
        MODI.MiLANGUAGES language;

        public ModiWrapper()
        {
            outputText = "Not Recognized";
        }

        public string getTextFromImageFile(string filePath, Language selectedLanguage, string selectedMode)
        {
            switch (selectedLanguage){
                case Language.SPANISH:
                    language=MODI.MiLANGUAGES.miLANG_SPANISH;
                    break;
                case Language.ENGLISH:
                    language=MODI.MiLANGUAGES.miLANG_ENGLISH;
                    break;
               case Language.FRENCH:
                    language=MODI.MiLANGUAGES.miLANG_FRENCH;
                    break;
                default:
                    language=MODI.MiLANGUAGES.miLANG_SPANISH;
                    break;

            }       

            


            return createMODI(filePath);

        }

        private string createMODI(string fileName){
            MODI.Document md = new MODI.Document(); 
            md.Create(fileName); 
            md.OCR(language,  true, true); 
            MODI.Image image = (MODI.Image)md.Images[0];
            outputText = image.Layout.Text;
            
            md.Close();
            return outputText;
            
        }

        }

    }
