/*Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 4
*/

Console.Write($"Введи количество чисел М: ");
int M = Convert.ToInt32(Console.ReadLine());
int[] massiveNumbers = new int[M];

void InputNumbers(int M){
for (int i = 0; i < M; i++)
  {
    Console.Write($"Введи {i + 1} число: ");
    massiveNumbers[i] = Convert.ToInt32(Console.ReadLine());
  }
}


int Comparison(int[] massiveNumbers)
{
  int count = 0;
  for (int i = 0; i < massiveNumbers.Length; i++)
  {
    if(massiveNumbers[i] > 0 ) count += 1; 
  }
  return count;
}

InputNumbers(M);

Console.WriteLine($"Введено чисел больше 0: {Comparison(massiveNumbers)} ");
