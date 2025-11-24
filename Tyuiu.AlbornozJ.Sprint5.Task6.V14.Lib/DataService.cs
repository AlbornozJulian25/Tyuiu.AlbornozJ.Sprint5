using System;
using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.AlbornozJ.Sprint5.Task6.V14.Lib
{
    public class DataService : ISprint5Task6V14
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            string text = File.ReadAllText(path);

            // Caracteres de puntuación a contar
            char[] punctuationMarks = { '.', ',', '!', '?', ';', ':', '-', '(', ')', '[', ']', '{', '}', '"', '\'' };

            foreach (char c in text)
            {
                if (Array.IndexOf(punctuationMarks, c) != -1)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
