﻿using System;

namespace Example2._22
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 1234.7;
            int a;
            // Cast double to int
            a = (int)x;

            Console.WriteLine("x = {0}", x);
            Console.WriteLine("a = {0}", a);

            Console.Write("Press a key to exit");
            Console.ReadKey();
        }
    }
}
