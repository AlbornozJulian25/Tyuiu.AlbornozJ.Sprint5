
using System;
using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.AlbornozJ.Sprint5.Task1.V28.Lib
{
    public class DataService : ISprint5Task1V28
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
                        
            if (File.Exists(path))
            {
                File.Delete(path);
            }
                        
            for (int x = startValue; x <= stopValue; x++)
            {
                double result;
                                
                if (Math.Abs(x - 0.7) < 0.0001)
                {
                    result = 0;
                }
                else
                {
                    result = Math.Cos(x) / (x - 0.7) - Math.Sin(x) * 12 * x + 2;
                    result = Math.Round(result, 2);
                }
                                
                if (x != stopValue)
                {
                    File.AppendAllText(path, result + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, result.ToString());
                }
            }

            return path;
        }
    }
}
