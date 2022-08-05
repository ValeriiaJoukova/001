// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.WriteLine("Введите целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int d = Convert.ToInt32(Console.ReadLine());
if( a > b && a > d) Console.WriteLine($"Максимальное число {a}");
else if( b > a && b > d) Console.WriteLine($"Максимальное число {b}");
else if( d > a && d > b) Console.WriteLine($"Максимальное число {d}");
