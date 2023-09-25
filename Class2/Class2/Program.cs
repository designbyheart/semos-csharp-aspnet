using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class2
{
    internal class Program
    {

        public static void Main(String[] args)
        {
            // Create an array and add 5 items to it
            Array stringArray = Array.CreateInstance(typeof(String), 5);

            stringArray.SetValue("Mahesh", 0);
            stringArray.SetValue("Raj", 1);
            stringArray.SetValue("Neel", 2);
            stringArray.SetValue("Beniwal", 3);
            stringArray.SetValue("Chand", 4);
            // Find an item
            object name = "Neel";
            int nameIndex = Array.BinarySearch(stringArray, name);
            if (nameIndex >= 0) Console.WriteLine($"Item was at {nameIndex.ToString()}th position");

            else Console.WriteLine("Item not found");
            Console.WriteLine();
            Console.WriteLine("Original Array");
            Console.WriteLine("---------------------");

                foreach (string str in stringArray)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine();
            Console.WriteLine("Sorted Array");
            Console.WriteLine("---------------------");
            Array.Sort(stringArray);

            foreach (string str in stringArray)
            {
                Console.WriteLine(str);
            }


        }
    }
}
