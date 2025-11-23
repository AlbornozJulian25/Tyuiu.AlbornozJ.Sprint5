using Tyuiu.AlbornozJ.Sprint5.Task2.V26.Lib;
Console.OutputEncoding = System.Text.Encoding.UTF8;

int[,] matrix = new int[3, 3] { { 2, -3, -3 },
                                { -8, 8, 0 },
                                { -6, 1, 0 } };

int rows = matrix.GetUpperBound(0) + 1;
int columns = matrix.Length / rows;

DataService ds = new DataService();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Массив: ");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{matrix[i, j]} \t");
    }
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Преобразованный массив: ");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        int value = matrix[i, j];
        if (value > 0) value = 1;
        else if (value < 0) value = 0;
        Console.Write($"{value} \t");
    }
    Console.WriteLine();
}

string res = ds.SaveToFileTextData(matrix);
Console.WriteLine();
Console.WriteLine("Файл: " + res);
Console.WriteLine("Создан!");
Console.ReadKey();
