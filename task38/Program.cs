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
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write(array[i]);
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
        if (max > arr[i]) max = arr[i];
        if (min < arr[i]) min = arr[i];
    }
    double Diff = min - max;
    return Diff;
}
Console.WriteLine($"Разница максимального и минимального значений = : {Diff(arr)}");