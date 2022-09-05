// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

// Функция 2. Cчёт суммы нечетных элементов
int[] Chet(int[] massive)
{
    int[] res = new int[1];
    for (int i = 0; i < massive.Length; i = i + 2)
    {
        res[0] += massive[i];    
    }
    return res;
}
// Конец второй функции

Console.Write("Введите размер массива: ");
int size_mas = int.Parse(Console.ReadLine());
Console.WriteLine("Введите наибольшее число отрезка: ");
int max = int.Parse(Console.ReadLine());
Console.WriteLine("Введите наименьшее число отрезка: ");
int min = int.Parse(Console.ReadLine());
int[] function1 = GetArray(size_mas, min, max);
Console.WriteLine("Your massive: ");
Console.WriteLine(String.Join(" ", function1));
int[] sum = Chet(function1);
Console.Write("Сумма элементов на нечетных позициях: ");
Console.WriteLine(String.Join(" ", sum));