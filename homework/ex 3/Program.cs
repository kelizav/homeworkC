// Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.
class Program
{
    static void PrintArrayReverse(int[] array, int index)
    {
        if (index >= 0)
        {
            Console.WriteLine(array[index]);
            PrintArrayReverse(array, index - 1);
        }
    }
    static void Main(string[] args)
    {
        Random random = new Random();
        int[] array = new int[10]; 

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(1, 101); 
        }

        Console.WriteLine("array elements starting from the end:");
        PrintArrayReverse(array, array.Length - 1);
    }
}