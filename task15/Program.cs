// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("Введите день недели;");
int a = Convert.ToInt32(Console.ReadLine());
if (a == 6 || a == 7) Console.WriteLine("выходной день");
else if (a > 7 || a < 1) Console.WriteLine("Неверно");
else Console.WriteLine("будни");