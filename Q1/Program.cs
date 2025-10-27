using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        bool isPrime = true;

        if (n < 2) isPrime = false;
        else
        {
            for (int i = 2; i * i <= n; i++)
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
        }

        Console.WriteLine(isPrime ? "Prime" : "Not Prime");
    }
}
