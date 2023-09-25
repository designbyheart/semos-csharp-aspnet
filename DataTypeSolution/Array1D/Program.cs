using System;

namespace Array1D {
  class Program {
    static void Main(string[] args) {
      int[] data1 = new int[3];
      int[] data2 = new int[] { 1, 2, 3};
      int[] data3 = { 4, 5, 6 };
      int[] data4 = data1;

      ShowArray(data1);
      ShowArray(data2);
      ShowArray(data3);
      data2 = new int[] { 9, 8, 7, 6 };
      ShowArray(data2);
      data1 = new int[] { 9, 8, 7, 6 };
      ShowArray(data1);
      Console.WriteLine("data1 == data2 is {0}", data1 == data2);
      Console.WriteLine("data1.Equals(data2) is {0}", data1.Equals(data2));


      Console.WriteLine(
        "#items in array referred by data1={0}",data1.Length);
      Console.WriteLine(
        "The dimension of array referred by data1={0}",
        data1.Rank);
      Console.WriteLine(
        "#items in array referred by data1={0}", 
        data1.GetLength(0));
      Console.ReadKey();
    }
    static void ShowArray(int[] data) {
      foreach (var item in data) Console.Write("\t{0}", item);
      //for(int i=0;i<data.Length;i++) Console.Write("\t{0}", data[i]);
      Console.WriteLine();
    }
  }
}
