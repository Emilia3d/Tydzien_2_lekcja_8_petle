using System;

class Program
{
    static bool IsPrime(int number)
    {
        if (number < 2)
            return false;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }

    static void Main()
    {
        int count = 0;

        for (int i = 0; i <= 100; i++)
        {
            if (IsPrime(i))
                count++;
        }

        Console.WriteLine("Liczba liczb pierwszych w zakresie 0 - 100: " + count);
    }
}
