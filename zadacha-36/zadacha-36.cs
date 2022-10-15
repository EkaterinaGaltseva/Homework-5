/* Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0

*/

int[] GetSize(int size)
{
    int [] Array = new int[size];
    Random rnd = new Random();
    
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = rnd.Next(-100, 100);
        
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

int GetSumm(int [] Array)
{
    int Summ = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] % 2 != 0)
            Summ += Array[i];
            
    }
    Console.Write($" -> {Summ}");
    return Summ;
}
Console.Write("Введите размерность массива:  ");
int SizeArray = int.Parse(Console.ReadLine());
int[] arr = GetSize(SizeArray);
PrintArray(arr);
int result = GetSumm(arr);