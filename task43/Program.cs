/*Задача 43: Напишите программу, 
которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

double[,] array = new double[2, 2];
double[] Point = new double[2];

void InputArray(){
  for (int i = 0; i < array.GetLength(0); i++)
  {
    Console.Write($"Введите коэффициенты {i+1}-го уравнения (y = k * x + b):\n");
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if(j == 0) Console.Write($"Введите коэффициент k: ");
      else Console.Write($"Введите коэффициент b: ");
      array[i,j] = Convert.ToInt32(Console.ReadLine());
    }
  }
}

double[] Decision(double[,] array)
{
  Point[0] = (array[1,1] - array[0,1]) / (array[0,0] - array[1,0]);
  Point[1] = Point[0] * array[0,0] + array[0,1];
  return Point;
}

void Output(double[,] array)
{
  if (array[0,0] == array[1,0] && array[0,1] == array[1,1]) 
  {
    Console.Write($"\nПрямые совпадают");
  }
  else if (array[0,0] == array[1,0] && array[0,1] != array[1,1]) 
  {
    Console.Write($"\nПрямые параллельны");
  }
  else 
  {
    Decision(array);
    Console.Write($"\nТочка пересечения прямых: ({Point[0]}, {Point[1]})");
  }
}

InputArray();
Output(array);