using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter odd n: ");
        int n = int.Parse(Console.ReadLine());

        for (int p = 2; p < n; p++)
        {
            if (IsPrime(p))
            {
                for (int q = 2; q < n; q++)
                {
                    if (IsPrime(q) && p + p * q == n)
                    {
                        Console.WriteLine(p + " + " + p + "*" + q + " = " + n);
                        return;
                    }
                }
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
