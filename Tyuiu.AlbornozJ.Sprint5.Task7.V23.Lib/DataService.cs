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

            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(pathSaveFile);
            }

            string text = File.ReadAllText(path, Encoding.UTF8);

            // Eliminar caracteres cirílicos (rusos)
            string newText = RemoveCyrillicCharacters(text);

            File.AppendAllText(pathSaveFile, newText, Encoding.UTF8);

            return pathSaveFile;
        }

        private string RemoveCyrillicCharacters(string text)
        {
            StringBuilder result = new StringBuilder();

            foreach (char c in text)
            {
                if (!IsCyrillic(c))
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }

        private bool IsCyrillic(char c)
        {
            return (c >= 'А' && c <= 'я') || c == 'ё' || c == 'Ё';
        }
    }
}
