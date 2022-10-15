/*Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

double[] GetSize(int size)
{
    double[] Array = new double[size];
    Random rnd = new Random();
    
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = rnd.Next(-10, 10)+rnd.NextDouble();    
    }
    return Array;   
}

void PrintArray(double[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write($" {Math.Round(Array[i], 2)} ");
    }
}
Console.WriteLine("\n");

double GetDiff(double[] Array)
{
    double Diff = 0;
    double MinValue = Array[0];
    double MaxValue = Array[0];

    for (int i = 1; i < Array.Length; i++)
    {
        if (Array[i] < MinValue)
            MinValue = Array[i];
        if (Array[i] > MaxValue)
            MaxValue = Array[i];
        Diff = MaxValue - MinValue;
    }
    return Diff;
}

Console.Write("Введите размерность массива:  ");
int SizeArray = int.Parse(Console.ReadLine());
double[] arr = GetSize(SizeArray);
PrintArray(arr);
double result = GetDiff(arr);
Console.WriteLine($"\n Разница -> {Math.Round(result, 2)} ");