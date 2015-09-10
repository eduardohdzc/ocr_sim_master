using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocr.Engine
{

    public enum Language
    {
        ENGLISH,
        SPANISH,
        GERMAN
    }

    public interface IOcrEngine
    {
        


        /// <summary>
        /// This function returns the string data acquired from an image. Supports JPG, GIF,TIFF and PNG files.
        /// </summary>
        /// <param name="filePath">Is the File name or path to the image to scan and transfor to text.</param>
        /// <param name="selectedLanguage">Set of characters to be identified based on selected language.</param>
        /// <param name="selectedMode">Single Character or Multicharacter recognition.</param>
        /// <returns>A string containing all recognized characters.</returns>
        string getTextFromImageFile(string filePath, Language selectedLanguage,  string selectedMode);
        
    }
}
