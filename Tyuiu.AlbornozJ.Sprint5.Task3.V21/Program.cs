using Tyuiu.AlbornozJ.Sprint5.Task3.V21.Lib;
Console.OutputEncoding = System.Text.Encoding.UTF8;

int x = 3;

DataService ds = new DataService();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("x = " + x);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

double numerator = Math.Pow(x, 2) + 1;
double denominator = Math.Sqrt(4 * Math.Pow(x, 2) - 3);
double y = numerator / denominator;
y = Math.Round(y, 3);

Console.WriteLine($"y({x}) = ({x}² + 1) / √(4*{x}² - 3) = {y}");

string res = ds.SaveToFileTextData(x);
Console.WriteLine("Файл: " + res);
Console.WriteLine("Создан!");
Console.ReadKey();