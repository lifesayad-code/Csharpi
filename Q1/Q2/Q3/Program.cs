using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter even n: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 2; i < n; i++)
        {
            if (IsPrime(i) && IsPrime(n - i))
            {
                Console.WriteLine(i + " + " + (n - i) + " = " + n);
                return;
            }
        }
    }

    static bool IsPrime(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i * i <= n; i++)
            if (n % i == 0) return false;
        return true;
    }
}
