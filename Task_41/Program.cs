/*Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3  */

Console.Write("Введите количество чисел: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[length];

for(int i = 0; i < length; i++)
{
    Console.Write($"Введите {i} число: ");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}

int count = 0;
for(int i = 0; i < length; i++)
{
    if(numbers[i] > 0)
    {
        count++;
    }
}

Console.WriteLine($"Количество положительных чисел: {count}");
