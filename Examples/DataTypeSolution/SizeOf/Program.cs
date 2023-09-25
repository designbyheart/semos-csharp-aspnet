using System;

namespace SizeOf {
  class Program {
    static void Main(string[] args) {
      Console.WriteLine("sizeof(sbyte)={0}", sizeof(sbyte));
      Console.WriteLine("sizeof(short)={0}", sizeof(short));
      Console.WriteLine("sizeof(int)={0}", sizeof(int));
      Console.WriteLine("sizeof(uint)={0}", sizeof(uint));
      Console.WriteLine("sizeof(long)={0}", sizeof(long));
      Console.WriteLine("sizeof(float)={0}", sizeof(float));
      Console.WriteLine("sizeof(double)={0}", sizeof(double));
      Console.WriteLine("sizeof(decimal)={0}", sizeof(decimal));
      Console.WriteLine("sizeof(char)={0}", sizeof(char));
      Console.WriteLine("sizeof(bool)={0}", sizeof(bool));
      Console.ReadKey();
    }
  }
}
