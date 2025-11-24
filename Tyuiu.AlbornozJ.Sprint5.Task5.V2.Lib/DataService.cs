using System;
using System.IO;
using System.Globalization;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.AlbornozJ.Sprint5.Task5.V2.Lib
{
    public class DataService : ISprint5Task5V2
    {
        public double LoadFromDataFile(string path)
        {
            double sum = 0;
            int count = 0;

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {                    
                    double number = Convert.ToDouble(line, CultureInfo.InvariantCulture);
                                        
                    if (number > 0)
                    {
                        sum += number;
                        count++;
                    }
                }
            }                        
            if (count > 0)
            {
                double average = sum / count;
                return Math.Round(average, 3);
            }

            return 0;
        }
    }
}
