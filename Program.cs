using System;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Net.Security;

class Program
{
    //ex.1
    static void Main()
    {
        //Console.WriteLine("\n ex. 1");
        //int count = 0;

        //for (int i = 0; i <= 100; i++)
        //{
        //    if (IsPrime(i))
        //        count++;
        //}

        //Console.WriteLine("Liczb pierwszych w zakresie 0 - 100 jest " + count + ".");

        //static bool IsPrime(int number)
        //{
        //    if (number < 2)
        //        return false;

        //    for (int i = 2; i <= Math.Sqrt(number); i++)
        //    {
        //        if (number % i == 0)
        //            return false;
        //    }

        //    return true;
        //}
        ////ex. 2
        //{
        //    Console.WriteLine("\n ex. 6");
        //    int i = 0;
        //    do
        //    {
        //        Console.WriteLine(i);
        //        i += 2;
        //    }
        //    while (i <= 1000);
        //}
        ////ex.3
        //{
        //    Console.WriteLine("\n ex. 3");
        //    Console.WriteLine("Do którego elementu ma wypisać ciąg Fibbonaciego?");
        //    string varLast = Console.ReadLine();
        //    int last = int.Parse(varLast);

        //    //int fibbonaci = 0;
        //    long fib1 = 0, fib2 = 1;
        //    int counter = 0;

        //    Console.Write("\n 0, ");
        //    do
        //    {
        //        fib2 = fib1 + fib2;
        //        fib1 = fib2 - fib1;
        //        counter++;
        //        Console.Write(fib1 + ", ");
        //    }
        //    while (counter < last);
        //}
        ////ex.4
        //{
        //    Console.WriteLine("\n ex. 4");
        //    Console.WriteLine("\n Do jakiej liczby narysować trójkąt?");
        //    string varLast = Console.ReadLine();
        //    int last = int.Parse(varLast);
        //    double level = 1;
        //    double factor = 1;

        //    for (int i = 1; i <= last; i++)
        //    {
        //        Console.Write($"{i} ");

        //        if (i / level == factor)
        //        {
        //            Console.WriteLine();
        //            factor = factor + 0.5;
        //            level++;
        //        }
        //    }
        //}
        ////ex.5
        //{
        //    Console.WriteLine("\n ex. 5");
        //    for (int i = 1; i <= 20; i++)
        //    {
        //        Console.WriteLine(i * i * i);
        //    }

        //    Console.WriteLine();
        //}
        ////ex.6
        //{
        //    Console.WriteLine("\n ex. 6");
        //    double sum = 0;
        //    for (double i = 1; i <= 20; i++)
        //    {
        //        sum = sum + (1 / i);
        //    }

        //    Console.WriteLine(sum);
        //}
        //ex.7
        {
            Console.WriteLine("\n ex. 7");
            Console.WriteLine("O jakiej (krótszej) przekątnej mam narysować diament? Wprowadź liczbę nieparzystą.");
            string varDiagonal = Console.ReadLine();
            int diagonal = int.Parse(varDiagonal);

            if (diagonal % 2 != 0)  //dla nieparzystych
            {
                for (int counterStars = 1; counterStars <= diagonal; counterStars = counterStars + 2)
                {
                    int counterSpace = (diagonal - counterStars) / 2;
                    Console.Write(new string(' ', counterSpace));
                    Console.Write(new string('*', counterStars));
                    Console.WriteLine(new string(' ', counterSpace));
                }

                for (int counterStars = diagonal - 2; counterStars >= 1; counterStars = counterStars - 2)
                {
                    int counterSpace = (diagonal - counterStars) / 2;
                    Console.Write(new string(' ', counterSpace));
                    Console.Write(new string('*', counterStars));
                    Console.WriteLine(new string(' ', counterSpace));
                }
            }

            else    //dla parzystych
            {
                for (int counterStars = 2; counterStars <= diagonal; counterStars = counterStars + 2)
                {
                    int counterSpace = (diagonal - counterStars) / 2;
                    Console.Write(new string(' ', counterSpace));
                    Console.Write(new string('*', counterStars));
                    Console.WriteLine(new string(' ', counterSpace));
                }

                for (int counterStars = diagonal; counterStars >= 2; counterStars = counterStars - 2)
                {
                    int counterSpace = (diagonal - counterStars) / 2;
                    Console.Write(new string(' ', counterSpace));
                    Console.Write(new string('*', counterStars));
                    Console.WriteLine(new string(' ', counterSpace));
                }
            }


        }
    }
}