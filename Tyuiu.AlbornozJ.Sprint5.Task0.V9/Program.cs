using Tyuiu.AlbornozJ.Sprint5.Task0.V9.Lib;
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

string res = ds.SaveToFileTextData(x);
Console.WriteLine("Файл: " + res);
Console.WriteLine("Создан!");


double y = Math.Pow(x, 3) / (Math.Pow(x, 2) - 1);
y = Math.Round(y, 3);
Console.WriteLine("y = " + y);

Console.ReadKey();
