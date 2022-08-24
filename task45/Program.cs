/*Задача 45: Напишите программу, которая будет 
создавать копию заданного массива с помощью поэлементного копирования.
*/

int[] array = {1, 4, 6, 8 ,2};
int[] newArray = new int [array.Length];

for (int i = 1; i < array.Length; i++)
{
    newArray[i] = array[i];
}

array[0] = 50;
Console.WriteLine(string.Join("", array));
Console.WriteLine(string.Join("", newArray));