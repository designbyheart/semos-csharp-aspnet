using System;
//Using ADT (Abstract Data Type)
namespace Matrix3 {
  class Program {
    static void Main(string[] args) {
      Matrix mA = new Matrix(3, 2,
        1,2,
        3,4,
        5,6);
      Matrix mB = new Matrix(2, 2, 
        1,2,
        3,4);
      try {
        Matrix mC = mA.Multiply(mB);
        mA.Show();
        Console.WriteLine("\t    X");
        mB.Show();
        Console.WriteLine("\t    =");
        mC.Show();
      } catch (Exception ex) {
        Console.WriteLine(ex.Message);
      }
      Console.ReadKey();
    }
  }
}
