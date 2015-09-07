using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocr.Engine
{
    public interface IOcrEngine
    {
        string getTextFromImageFile(string filePath);
    }
}
