// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// Функция 1. Заполнения массива трехзначными положительными числами на заданный размер массива
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] Massive = new int[size];
    for (int i = 0; i < size; i++)
    {
        Massive[i] = new Random().Next(minValue, maxValue + 1);
    }
    return Massive;
}
// Конец первой функции

// Функция 2. Подсчет четных чисел массива
int[] Chet(int[] array)
{
    int[] res = new int[1];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            res[0] ++;
        }
    }
    return res;
}
// Конец второй функции

Console.Write("Введите размер массива:  ");
int size_mas = int.Parse(Console.ReadLine());
int[] function1 = GetArray(size_mas, 100, 999);
Console.WriteLine("Your massive: ");
Console.WriteLine(String.Join(" ", function1));
int[] result = Chet(function1);
Console.Write("Количество четных чисел в массиве: ");
Console.WriteLine(String.Join(" ", result));