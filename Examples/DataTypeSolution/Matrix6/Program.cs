using System;
//Using Class Operations
namespace Matrix6 {
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
      //(Matrix.Add(Matrix.Multiply(mA, Matrix.Transpose(mB)), mC)).Show();
      //(Matrix.operator+(Matrix.operator*(mA, Matrix.operator~(mB)), mC)).Show();
      ((mA * ~mB) + mC).Show();
      Console.WriteLine((mA * ~mB) + mC);
      Console.ReadKey();
    }
  }
}
