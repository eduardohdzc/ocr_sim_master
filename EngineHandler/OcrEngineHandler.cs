using Ocr.Wrapper;
using Ocr.Wrapper.ModiWrapper;
using Ocr.Wrapper.AspriseWrapper;
using Ocr.Wrapper.TesseractWrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocr.Engine.Handler
{
    public class OcrEngineHandler
    {
        public static IOcrEngine createEngine()
        {
            //IOcrEngine engineWrapper = new AspriseWrapper();
            IOcrEngine engineWrapper = new TesseractWrapper();
            //IOcrEngine engineWrapper = new ModiWrapper();

            return engineWrapper;
        }

        // Factory abstract
        public static IOcrEngine createEngine(string engine)
        {
            if (engine.Equals("MODI"))
            {
                return new ModiWrapper();
            }
            else if (engine.Equals("Tesseract"))
            {
                return new TesseractWrapper();
            }
            else if (engine.Equals("Asprise"))
            {
                return new AspriseWrapper();
            }
            return new TesseractWrapper();
        }
    }
}
