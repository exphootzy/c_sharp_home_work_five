// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

var watch = new System.Diagnostics.Stopwatch();
watch.Start();

int[] CreateArray()
{
    Random random = new Random();
    int a = random.Next(8, 16);
    int[] numbers = new int[a];
    Console.WriteLine($"Рандомное число для длинны массива: {a}");
    for (int x = 0; x < numbers.Length; x++)
    {
        {
            numbers[x] = random.Next(1, 21);

        }
    }
    return numbers;
}

void PrintArray(int[] array)
{
    int count = array.Length;
    Console.Write("Исходный массив: ");
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int SearchSummVoid(int[] arr)
{
    int summ = 0;
    for (int i = 0; i<arr.Length; i++)
    {
        if (i % 2 != 0)
            summ += arr[i];
    }
    return summ;
}

int[] arr = CreateArray();
PrintArray(arr);
System.Console.WriteLine($"Сумма чисел стоящих на нечетных позициях: {SearchSummVoid(arr)}");

watch.Stop();
Console.WriteLine($"Время работы кода: {watch.ElapsedMilliseconds} мc");
