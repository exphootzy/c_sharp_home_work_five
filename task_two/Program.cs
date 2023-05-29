// Задача 38: Задайте массив вещественных чисел. Найдите разницу между
// максимальным и минимальным элементов массива.

var watch = new System.Diagnostics.Stopwatch();
watch.Start();

double[] CreateArray()
{
    Random random = new Random();
    int a = random.Next(8, 16);
    double [] numbers = new double[a];
    Console.WriteLine($"Рандомное число для длинны массива: {a}");
    for (int x = 0; x < numbers.Length; x++)
    {
        {
            numbers[x] = random.NextDouble() * (20.99 + 1.00) - 1.00;
        }
    }
    return numbers;
}

void PrintArray(double[] array)
{
    int count = array.Length;
    Console.Write("Исходный массив: ");
    for (int i = 0; i < count; i++)
    {
        Console.Write(Math.Round(array[i], 2));
        Console.Write($" ");
    }
    Console.WriteLine();
}

void PrintDifferenceMaxMin(double[] arr)
{
    double temp;
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = 0; j < arr.Length - 1 - i; j++)
        {
            if (arr[j] > arr[j + 1])
            {
                temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
        }
    }
    double summ = arr[arr.Length-1] - arr[0];
    System.Console.Write($"Разница между максимальным и минимальным значением массива: ");
    System.Console.Write(Math.Round(summ, 2));
    System.Console.WriteLine();
 }

double[] arr = CreateArray();
PrintArray(arr);
PrintDifferenceMaxMin(arr);

watch.Stop();
Console.WriteLine($"Время работы кода: {watch.ElapsedMilliseconds} мc");