// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// Функция 1. Заполнениe массива
double[] GetArray(int size, double minValue, double maxValue)
{
    double[] massive = new double[size];
    for (int i = 0; i < size; i++)
    {
        massive[i] = new Random().Next(minValue, maxValue + 1);
    }
    return massive;
}
// Конец первой функции
// Функция 2. Найдем max
double[] Chet1(double[] massive)
{
    double[] maxZnach = new double[1];
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
double[] Chet2(double[] massive)
{
    double[] minZnach = new double[1];
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
double[] Chet3(double[] minZnach, double[] maxZnach)
{
    double[] delta = new double[1];
    delta[0] = maxZnach[0] - minZnach[0];
    return delta;
}
// Параметры массива:
Console.Write("Введите размер массива: ");
int size_mas = int.Parse(Console.ReadLine());
Console.Write("Введите min число массива: ");
double min = double.Parse(Console.ReadLine());
Console.Write("Введите max число массива: ");
double max = double.Parse(Console.ReadLine());
// Выводим массив на экран:
double[] function1 = GetArray(size_mas, min, max);
Console.Write("Массив: ");
Console.WriteLine(String.Join(" ", function1));
// Выводим max-min значение массива
double[] result1 = Chet1(function1);
Console.Write("Max: ");
Console.WriteLine(String.Join(" ", result1));
double[] result2 = Chet2(function1);
Console.Write("Min: ");
Console.WriteLine(String.Join(" ", result2));
// Выводим разницу меж результатами
double[] result = Chet3(result2, result1);
Console.Write("Расстояние между левой и правой точкой отрезка: ");
Console.WriteLine(String.Join(" ", result));