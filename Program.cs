﻿using System;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Net.Security;

class Program
{
    //ex.1
    static void Main()
    {
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
        //    int i = 0;
        //    do
        //    {
        //        Console.WriteLine(i);
        //        i += 2;
        //    }
        //    while (i <= 1000);
        //}
        ////ex.3
        ////POPRAWIĆ (0- 1-szy el. ciągu)
        //{
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
        //ex.4 POPRAWIĆ
        {
            Console.WriteLine("\n Do jakiej liczby narysować trójkąt?");
            string varLast = Console.ReadLine();
            int last = int.Parse(varLast);
            int level = 1;
            double factor = 1.0;

            for (int i = 1; i <= last; i++)
            {
                Console.Write(i);
                Console.WriteLine("\nliczba = " + i);
                Console.WriteLine("level = " + level);
                Console.WriteLine("factor = " + factor);

                if (i / level == factor)
                {
                    Console.WriteLine("");
                    factor = factor + 0.5;
                    level++;
                }

                else
                {
                    Console.WriteLine("level bez zmian");
                }
            }
        }
        //ex.5
        {
            Console.WriteLine("ex. 5");
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(i*i*i);
            }

            Console.WriteLine();
        }
        //ex.6
        {
            Console.WriteLine("ex. 6");
            double sum = 0.0;
            for (int i = 1; i <= 20; i++)
            {
                sum = sum + (1/i);
            }

            Console.WriteLine(sum);
        }
    }
}