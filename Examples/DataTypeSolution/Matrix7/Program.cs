using System;
//Overload ToString
namespace Matrix7 {
  class Program {
    static void Main(string[] args) {
      Matrix mA = new Matrix(3, 2,
        1, 2,
        3, 4,
        5, 6
      );
      Matrix mB = new Matrix(3, 2,
        4, 3,
        5, 1,
        0, 6
      );
      Matrix mC = new Matrix(3, 3,
        2, 1, 5,
        6, 4, 0,
        3, 2, 1
      );

      Console.WriteLine((mA * ~mB) + mC);
      //string s = ((mA * ~mB) + mC).ToString();
      Console.WriteLine("-------------------------");
      Console.WriteLine(mA);
      Console.WriteLine("-------------------------");
      Console.WriteLine(mA * 5);
      Console.WriteLine("-------------------------");
      Console.WriteLine(5 * mA);
      Console.ReadKey();
    }
  }
}
