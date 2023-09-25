using System;
//Using Indexer
namespace Matrix8 {
  class Program {
    static void Main(string[] args) {
      Matrix m = new Matrix(3, 3,
        2, 1, 5,
        6, 4, 0,
        3, 2, 1
      );

      Matrix m2 = new Matrix(3, 3,
        2, 1, 5,
        6, 4, 0,
        3, 2, 1
      );
      Console.WriteLine("m==m2 is " + (m == m2));
      Console.WriteLine("m.Equals(m2) is " + m.Equals(m2));
      Console.WriteLine("Matrix.ReferenceEquals(m,m2) is " + Matrix.ReferenceEquals(m,m2));



      Console.WriteLine(m);
      m[2, 1] = -2;
      m[1, 2] = 88;
      int cell = m[0, 2];

      Console.WriteLine(m);
      Console.WriteLine(m[7]);
      Console.WriteLine(m["First"]);
      m["Last"] = 99;
      Console.WriteLine(m["Last"]);

      m = new Matrix(1, 4,    1, 2, 3, 4);

      Console.WriteLine(m[0, 2]);
      Console.WriteLine(m[2]);

      m = new Matrix(4, 1, 
        1, 
        2, 
        3, 
        4);

      Console.WriteLine(m[2, 0]);
      Console.WriteLine(m[2]);

      Console.ReadKey();
    }
  }
}
