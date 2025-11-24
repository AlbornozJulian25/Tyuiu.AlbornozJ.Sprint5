using System;
using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.AlbornozJ.Sprint5.Task4.V20.Lib
{
    public class DataService : ISprint5Task4V20
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            double x = Convert.ToDouble(strX, System.Globalization.CultureInfo.InvariantCulture);

            double numerator = Math.Pow(x, 2);
            double denominator = Math.Sin(x);
                        
            if (Math.Abs(denominator) < 0.0001)
                return 0;

            double y = Math.Pow(numerator / denominator, 3);
            y = Math.Round(y, 3);

            return y;
        }
    }
}
