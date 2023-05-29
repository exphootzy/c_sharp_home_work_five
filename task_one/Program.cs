// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

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
            numbers[x] = random.Next(100, 1000);

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

int SearchVoidNumbers(int[] arr)
{
    int count = 0;
    foreach (var element in arr)
    {
        if (element % 2 == 0)
            count++;
    }
    return count;
}

int[] arr = CreateArray();
PrintArray(arr);
System.Console.WriteLine($"Колличество четных числе в массиве: {SearchVoidNumbers(arr)}");

watch.Stop();
Console.WriteLine($"Время работы кода: {watch.ElapsedMilliseconds} мc");