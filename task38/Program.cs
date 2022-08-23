// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2
double[] CreateArrayRndInt(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1) + rnd.NextDouble();
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{Math.Round(array[i], 1, MidpointRounding.ToZero)}, ");
        else Console.Write(Math.Round(array[i], 1, MidpointRounding.ToZero));
    }
    Console.Write("]");
    Console.WriteLine();
}

double[] arr = CreateArrayRndInt (5, 1, 100);
PrintArray(arr);

double Diff(double[] arr)
{
    double max = arr[0];
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {    
        if (max > arr[i]) min = arr[i];
        if (min < arr[i]) max = arr[i];
    }
    double Diff = max - min;
    return Diff;
}
Console.WriteLine($"Разница максимального и минимального значений = {Math.Round(Diff(arr), 2, MidpointRounding.ToZero)}");