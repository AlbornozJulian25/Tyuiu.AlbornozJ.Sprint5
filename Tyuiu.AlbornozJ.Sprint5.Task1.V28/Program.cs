using Tyuiu.AlbornozJ.Sprint5.Task1.V28.Lib;
Console.OutputEncoding = System.Text.Encoding.UTF8;

int startValue = -5;
int stopValue = 5;

DataService ds = new DataService();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("startValue = " + startValue);
Console.WriteLine("stopValue = " + stopValue);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("+----------+-----------+");
Console.WriteLine("|    x     |   F(x)    |");
Console.WriteLine("+----------+-----------+");

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

    Console.WriteLine($"| {x,5}    | {result,8}  |");
}
Console.WriteLine("+----------+-----------+");

string res = ds.SaveToFileTextData(startValue, stopValue);
Console.WriteLine("Файл: " + res);
Console.WriteLine("Создан!");
Console.ReadKey();
