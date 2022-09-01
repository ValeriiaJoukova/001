// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
double[,] value = new double[2, 2];
double[] crossPoint = new double[2];

void InputValue()
{
  for (int i = 0; i < value.GetLength(0); i++)
  {
    Console.WriteLine($"Введите значения {i+1}-й прямой ");
    for (int j = 0; j < value.GetLength(1); j++)
    {
      if(j==0) Console.Write($"Введите значение k: ");
      else Console.Write($"Введите значение b: ");
      value[i,j] = Convert.ToInt32(Console.ReadLine());
    }
  }
}

double[] Decision(double[,] value)
{
  crossPoint[0] = (value[1,1] - value[0,1]) / (value[0,0] - value[1,0]);
  crossPoint[1] = crossPoint[0] * value[0,0] + value[0,1];
  return crossPoint;
}

void OutputResponse(double[,] value)
{
  if (value[0,0] == value[1,0] && value[0,1] == value[1,1]) 
  {
    Console.Write($"\nПрямые совпадают");
  }
  else if (value[0,0] == value[1,0] && value[0,1] != value[1,1]) 
  {
    Console.Write($"\nПрямые параллельны");
  }
  else 
  {
    Decision(value);
    Console.Write($"\nТочка пересечения прямых: ({crossPoint[0]}; {crossPoint[1]})");
  }
}

InputValue();
OutputResponse(value);