// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// Функция 1. Заполнениe массива
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] massive = new int[size];
    for (int i = 0; i < size; i++)
    {
        massive[i] = new Random().Next(minValue, maxValue + 1);
    }
    return massive;
}
// Конец первой функции
// Функция 2. Найдем max
int[] Chet1(int[] massive)
{
    int[] maxZnach = new int[1];
    maxZnach[0] = massive[0];
    for (int i = 0; i < massive.Length; i++)
    {
        if (massive[i] > maxZnach[0])
        {
            maxZnach[0] = massive[i];
        }
    }
    return maxZnach;
}
// Конец второй функции
// Функция 3. Найдем min
int[] Chet2(int[] massive)
{
    int[] minZnach = new int[1];
    minZnach[0] = massive [0];
    for (int i = 0; i < massive.Length; i++)
    {
        if (massive[i] < minZnach[0])
        {
            minZnach[0] = massive[i];
        }
    }
    return minZnach;
}
// Конец третей функции
// Функция 4. Найдем max-min
int[] Chet3(int[] minZnach, int[] maxZnach)
{
    int[] delta = new int[1];
    delta[0] = maxZnach[0] - minZnach[0];
    return delta;
}
// Параметры массива:
Console.Write("Введите размер массива: ");
int size_mas = int.Parse(Console.ReadLine());
Console.Write("Введите min число массива: ");
int min = int.Parse(Console.ReadLine());
Console.Write("Введите max число массива: ");
int max = int.Parse(Console.ReadLine());
// Выводим массив на экран:
int[] function1 = GetArray(size_mas, min, max);
Console.Write("Массив: ");
Console.WriteLine(String.Join(" ", function1));
// Выводим max-min значение массива
int[] result1 = Chet1(function1);
Console.Write("Max: ");
Console.WriteLine(String.Join(" ", result1));
int[] result2 = Chet2(function1);
Console.Write("Min: ");
Console.WriteLine(String.Join(" ", result2));
// Выводим разницу меж результатами
int[] result = Chet3(result2, result1);
Console.Write("Расстояние между левой и правой точкой отрезка: ");
Console.WriteLine(String.Join(" ", result));