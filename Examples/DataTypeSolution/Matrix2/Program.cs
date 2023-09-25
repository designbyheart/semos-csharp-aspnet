using System;
//Using 2D Array
namespace Matrix2 {
  class Program {
    static void MainTranspose(string[] args) {
      int[,] mA ={
        {1,2},
        {3,4},
        {5,6},
      };
      int[,] mAT = new int[mA.GetLength(1), mA.GetLength(0)];
      for (int r = 0; r < mAT.GetLength(0); r++) {
        for (int c = 0; c < mAT.GetLength(1); c++) {
          mAT[r, c] = mA[c, r];
        }
      }
      ShowMatrix(mA);
      Console.WriteLine("\t    =");
      ShowMatrix(mAT);
      Console.ReadKey();
    }


    static void MainAdd(string[] args) {
      int[,] mA ={
        {1,2},
        {3,4},
        {5,6},
      };
      int[,] mB ={
        {1,1},
        {2,2},
        {3,3},
      };
      if ((mA.GetLength(0) == mB.GetLength(0))&&(mA.GetLength(1) == mB.GetLength(1))) {
        int[,] mC = new int[mA.GetLength(0), mA.GetLength(1)];
        for (int r = 0; r < mC.GetLength(0); r++) {
          for (int c = 0; c < mC.GetLength(1); c++) {
            mC[r, c] = mA[r, c] + mB[r, c];
          }
        }
        ShowMatrix(mA);
        Console.WriteLine("\t    +");
        ShowMatrix(mB);
        Console.WriteLine("\t    =");
        ShowMatrix(mC);
      } else Console.WriteLine("Cannot Add-lah!");
      Console.ReadKey();
    }


    static void Main(string[] args) {
      int[,] mA={
        {1,2},
        {3,4},
        {5,6},
      };
      int[,] mB={
        {1,2},
        {3,4},
      };
      if (mA.GetLength(1) == mB.GetLength(0)) {
        int[,] mC = new int[mA.GetLength(0),mB.GetLength(1)];
        for (int r = 0; r < mC.GetLength(0); r++) {
          for (int c = 0; c < mC.GetLength(1); c++) {
            for (int i = 0; i < mB.GetLength(0); i++) {
              mC[r,c] += mA[r,i] * mB[i,c];
            }
          }
        }
        ShowMatrix(mA);
        Console.WriteLine("\t    X");
        ShowMatrix(mB);
        Console.WriteLine("\t    =");
        ShowMatrix(mC);
      } else Console.WriteLine("Cannot multiply-lah!");
      Console.ReadKey();
    }
    static void ShowMatrix(int[,] m) {
      for (int r = 0; r < m.GetLength(0); r++) {
        for (int c = 0; c < m.GetLength(1); c++) Console.Write("\t{0}", m[r,c]);
        Console.WriteLine();
      }
      Console.WriteLine();
    }
  }
}
