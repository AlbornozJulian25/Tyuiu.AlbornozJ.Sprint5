using System;
using System.IO;
using System.Text;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.AlbornozJ.Sprint5.Task7.V23.Lib
{
    public class DataService : ISprint5Task7V23
    {
        public string LoadDataAndSave(string path)
        {
            string tempPathForSaveFile = Path.GetTempPath();
            string pathSaveFile = Path.Combine(tempPathForSaveFile, "OutPutDataFileTask7V23.txt");

            if (File.Exists(pathSaveFile))
            {
                File.Delete(pathSaveFile);
            }

            string[] lines = File.ReadAllLines(path, Encoding.UTF8);

            using (StreamWriter writer = new StreamWriter(pathSaveFile, false, Encoding.UTF8))
            {
                foreach (string line in lines)
                {
                    string processedLine = ProcessLine(line);
                    if (!string.IsNullOrWhiteSpace(processedLine))
                    {
                        writer.WriteLine(processedLine);
                    }
                }
            }
            return pathSaveFile;
        }

        private string ProcessLine(string line)
        {
            StringBuilder result = new StringBuilder();
            bool lastWasSpace = false;

            foreach (char c in line)
            {
                if (!IsCyrillic(c))
                {
                    if (char.IsWhiteSpace(c))
                    {
                        if (!lastWasSpace && result.Length > 0)
                        {
                            result.Append(' ');
                            lastWasSpace = true;
                        }
                    }
                    else
                    {
                        result.Append(c);
                        lastWasSpace = false;
                    }
                }
            }

            
            string cleanedResult = RemoveSpacesBeforePunctuation(result.ToString());
            return cleanedResult.Trim();
        }

        private bool IsCyrillic(char c)
        {
            return (c >= 'А' && c <= 'я') || c == 'ё' || c == 'Ё';
        }

        
        private string RemoveSpacesBeforePunctuation(string text)
        {
            if (string.IsNullOrEmpty(text))
                return text;

            
            text = text.Replace(" .", ".");
            text = text.Replace(" ,", ",");
            text = text.Replace(" !", "!");
            text = text.Replace(" ?", "?");
            text = text.Replace(" ;", ";");
            text = text.Replace(" :", ":");

            return text;
        }
    }
}
