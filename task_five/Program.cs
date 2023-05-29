// Задача VERY HARD необязательная Имеется массив случайных целых чисел. Создайте массив, в который попадают числа,
// описывающие максимальную сплошную возрастающую последовательность. Порядок элементов менять нельзя.
// Одно число - это не последовательность.

// Пример:

// [1, 5, 2, 3, 4, 6, 1, 7] => [1, 7] так как здесь вразброс присутствуют все числа от 1 до 7

// [1, 5, 2, 3, 4, 1, 7, 8 , 15 , 1 ] => [1, 5] так как здесь есть числа от 1 до 5 и эта последовательность длиннее чем от 7 до 8

// [1, 5, 3, 4, 1, 7, 8 , 15 , 1 ] => [3, 5] так как здесь есть числа от 3 до 5 и эта последовательность длиннее чем от 7 до 8



using System.Text; // Это для использования стринг билдера см. стр. 70

var watch = new System.Diagnostics.Stopwatch();
watch.Start();

int[] GetMaxIncreasingSequence(int[] arr) // Получаем максимальную возрастающую последовательность
{
    List<int[]> sequences = new List<int[]>(); // Структура данных, которая как массив, только он динамический.
    foreach (int element in arr)
    {
        int[] sequenceArray = FindSequence(element, arr);
        sequences.Add(sequenceArray);
    }

    int[] maxLengthSequence = GetMaxLengthSequence(sequences);

    return maxLengthSequence;
}

int[] GetMinMax(int[] arr)
{
    int[] answer = new int[2];
    answer[0] = arr[0];
    answer[1] = arr[arr.Length - 1];
    return answer;
}

int[] FindSequence(int number, int[] arr)
{
    List<int> answer = new List<int>(); // Структура данных, которая как массив, только он динамический.

    answer.Add(number); // Эта команда записывает элемент в массив
    SearchElement(number + 1, arr, answer);

    return answer.ToArray(); // Этой командой копируем элементы листа в массив
}

int[] GetMaxLengthSequence(List<int[]> sequences)
{
    int[] maxLengthSequence = sequences[0];
    foreach (int[] sequence in sequences)
    {
        if (sequence.Length > maxLengthSequence.Length)
        {
            maxLengthSequence = sequence;
        }
    }

    return maxLengthSequence;
}

void SearchElement(int number, int[] arr, List<int> sequence)
{
    foreach (int element in arr)
    {
        if (element == number)
        {
            sequence.Add(element);
            number++;
            SearchElement(number, arr, sequence);

            return;
        }
    }
}

void ShowArray(int[] arr)
{
    StringBuilder stringBuilder = new StringBuilder();

    stringBuilder.Append("[");
    for (int i = 0; i < arr.Length; i++)
    {
        stringBuilder.Append(arr[i]);
        if (i != arr.Length - 1)
        {
            stringBuilder.Append(", ");
        }
    }
    stringBuilder.Append("]");
    Console.WriteLine(stringBuilder.ToString());
}

int[] CreateArray()
{
    Random random = new Random();
    int a = random.Next(8, 16);
    int[] numbers = new int[a];
    Console.WriteLine($"Рандомное число для длинны массива: {a}");
    for (int x = 0; x < numbers.Length; x++)
    {
        {
            numbers[x] = random.Next(1, 16);

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

int[] arr = CreateArray();
PrintArray(arr);
// int[] arr = new int[] {1, 5, 3, 4, 1, 7, 8 , 15 , 1};
ShowArray(GetMinMax(GetMaxIncreasingSequence(arr)));

watch.Stop();
Console.WriteLine($"Время работы кода: {watch.ElapsedMilliseconds} мc");