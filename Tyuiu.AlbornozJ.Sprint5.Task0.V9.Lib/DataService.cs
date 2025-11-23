using System;
using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.AlbornozJ.Sprint5.Task0.V9.Lib
{
    public class DataService : ISprint5Task0V9
    {
        public string SaveToFileTextData(int x)
        {
            double y = Math.Pow(x, 3) / (Math.Pow(x, 2) - 1);
            y = Math.Round(y, 3);
                        
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");
                        
            File.WriteAllText(path, y.ToString());

            return path;
        }
    }
}
