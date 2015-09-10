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
            // TODO: change this line with the actual call to the abstract factory
            //IOcrEngine engineWrapper = new AspriseWrapper();
            IOcrEngine engineWrapper = new TesseractWrapper();
            //IOcrEngine engineWrapper = new ModiWrapper();

            return engineWrapper;
        }       
    }
}
