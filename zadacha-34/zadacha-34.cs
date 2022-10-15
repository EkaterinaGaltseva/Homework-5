/*Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/

int[] GetSize(int size)
{
    int [] Array = new int[size];
    Random rnd = new Random();
    
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = rnd.Next(100, 1000);
        
    }
    return Array;   
}

void PrintArray(int [] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write($" {Array[i]}");
    }
}
Console.WriteLine("\n");
int GetEvenOnes(int [] Array)
{
    int Quantity = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] % 2 == 0)
            Quantity += 1;
            
    }
    Console.Write($" -> {Quantity}");
    return Quantity;
}
Console.Write("Введите размерность массива:  ");
int SizeArray = int.Parse(Console.ReadLine());
int[] arr = GetSize(SizeArray);
PrintArray(arr);
int result = GetEvenOnes(arr);