using Ocr.Wrapper;
//using Ocr.Wrapper.ModiWrapper;
using Ocr.Wrapper.Asprise;
//using Ocr.Wrapper.TesseractWrapper;
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
            IOcrEngine engineWrapper = new AspriseWrapper();
            
            return engineWrapper;
        }       
    }
}
