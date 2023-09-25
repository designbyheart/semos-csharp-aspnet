using System;
using System.Net.Http.Headers;

namespace ConsoleApp1
{
    internal class DebugClass
    {
        int Parametar1 { get; set; }
        int Parametar2 { get; set; }
        static void Main(string[] args)
        {
            //   Console.WriteLine(IsResultTheSame(3, 4));
            DebugClass obj = new DebugClass();
            Console.WriteLine(obj.IsResultTheSame(3, 4));
        }

        /*
          public static bool IsResultTheSame (int parametar1, int parametar2)
        {
            Parametar1 = int parametar1;
            if parametar1 = parametar2
               return true;
             else
                return false;
        }
         */

        public bool IsResultTheSame(int parametar1, int parametar2)
        {
            Parametar1 = parametar1;

            if (parametar1 == parametar2) {
                return true;
            }
               
            return false;
        }
    }
}