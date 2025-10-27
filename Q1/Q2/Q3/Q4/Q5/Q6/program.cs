using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter m: ");
        int m = int.Parse(Console.ReadLine());

        for (int x = n; x <= m; x++)
        {
            if (IsPrime(x))
                Console.WriteLine(x + " is Prime");

            else if (x % 2 == 0)
            {
                for (int i = 2; i < x; i++)
                    if (IsPrime(i) && IsPrime(x - i))
                    {
                        Console.WriteLine(x + " = " + i + " + " + (x - i));
                        break;
                    }
            }
            else
            {
                for (int p = 2; p < x; p++)
                    if (IsPrime(p) && (x - p) % 2 == 0 && IsPrime((x - p) / 2))
                    {
                        Console.WriteLine(x + " = " + p + " + 2*" + (x - p) / 2);
                        break;
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
