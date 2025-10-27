using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        if (IsPrime(n))
        {
            Console.WriteLine("Prime");
        }
        else if (n % 2 == 0)
        {
            Console.WriteLine("Even (Goldbach):");
            for (int i = 2; i < n; i++)
                if (IsPrime(i) && IsPrime(n - i))
                {
                    Console.WriteLine(i + " + " + (n - i) + " = " + n);
                    return;
                }
        }
        else
        {
            Console.WriteLine("Odd (Lemoine):");
            for (int p = 2; p < n; p++)
                if (IsPrime(p) && (n - p) % 2 == 0 && IsPrime((n - p) / 2))
                {
                    Console.WriteLine(n + " = " + p + " + 2*" + (n - p) / 2);
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
