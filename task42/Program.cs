/*Задача 42: Напишите программу, 
которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10
*/
void ReverseArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
}

Console.WriteLine("Введите чисо: ");
int number = int.Parse(Console.ReadLine()!);
int size =(int)Math.Log2(number) + 1;
int [] array = new int[size];

for (int i = 0; i < array.Length; i++)
{
    array[i] = number % 2;
    number = number / 2;
}
ReverseArray(array);
Console.WriteLine(string.Join("", array));
