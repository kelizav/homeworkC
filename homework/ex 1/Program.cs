// Задайте значения M и N. 
//Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.
class Program
{
    static void PrintNumbers(int m, int n)
    {
        if (m <= n)
        {
            Console.WriteLine(m);
            PrintNumbers(m + 1, n);
        }
    }
    static void Main(string[] args)
    {
        Console.Write("enter the value of M: ");
        string inputM = Console.ReadLine();
        
        Console.Write("enter the value of N: ");
        string inputN = Console.ReadLine();
        int M, N;

        if (inputM != null && inputN != null && int.TryParse(inputM, out M) && int.TryParse(inputN, out N))
        {
            Console.WriteLine($"all numbers from {M} to {N}:");
            PrintNumbers(M, N);
        }
    }
}
