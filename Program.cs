//Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.
while (true)
{
    Console.Clear();
    int[] array = GetArrayRndInt();
    PrintArray(array);
    System.Console.WriteLine("\n");
    OutputReverseArray(array);
    Console.ReadLine();

    void OutputReverseArray(int[] a, int i = 0)
    {
        if (i > a.Length - 1)
            return;
        OutputReverseArray(a, i + 1);
        Console.Write(" " + a[i]);
    }

    int[] GetArrayRndInt()
    {
        Random rnd = new Random();
        int[] array = new int[rnd.Next(100)];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rnd.Next(100);
        }
        return array;
    }

    void PrintArray(int[] array)
    {
        System.Console.WriteLine("Сгенерированный массив: ");
        for (int i = 0; i < array.Length; i++)
        {
            System.Console.Write(array[i] + " ");
        }
    }
}