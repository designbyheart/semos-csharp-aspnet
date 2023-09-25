using System;
//Using Array of Array
namespace Matrix1 {
  class Program {
    static void Main(string[] args) {
      int[][] mA = new int[][]{
        new int[]{1,2},
        new int[]{3,4},
        new int[]{5,6},
      };
      int[][] mAt = new int[mA[0].Length][];
        for (int r = 0; r < mAt.Length; r++) {
          mAt[r] = new int[mA.Length];
          for (int c = 0; c < mAt[0].Length; c++) {
            mAt[r][c] = mA[c][r];
          }
        }
        ShowMatrix(mA);
      Console.WriteLine("\t    |");
      Console.WriteLine("\t    v");
      ShowMatrix(mAt);
      Console.ReadKey();
    }


    static void MainAdd(string[] args) {
      int[][] mA = new int[][]{
        new int[]{1,2},
        new int[]{3,4},
        new int[]{5,6},
      };
      int[][] mB = new int[][]{
        new int[]{1,1},
        new int[]{2,2},
        new int[]{3,3},
      };
      if ((mA.Length == mB.Length) && (mA[0].Length == mB[0].Length)) {
        int[][] mC = new int[mA.Length][];
        for (int r = 0; r < mC.Length; r++) {
          mC[r] = new int[mA[0].Length];
          for (int c = 0; c < mC[0].Length; c++) {
            mC[r][c] = mA[r][c] + mB[r][c];
          }
        }
        ShowMatrix(mA);
        Console.WriteLine("\t    +");
        ShowMatrix(mB);
        Console.WriteLine("\t    =");
        ShowMatrix(mC);
      } else Console.WriteLine("Cannot add-lah!");
      Console.ReadKey();
    }

    static void MainMul(string[] args) {
      int[][] mA=new int[][]{
        new int[]{1,2},
        new int[]{3,4},
        new int[]{5,6},
      };
      int[][] mB ={
        new int[]{1,2},
        new int[]{3,4},
      };
      if (mA[0].Length == mB.Length) {
        int[][] mC = new int[mA.Length][];
        for (int r = 0; r < mC.Length; r++) {
          mC[r] = new int[mB[0].Length];
          for (int c = 0; c < mC[0].Length; c++) {
            for (int i = 0; i < mB.Length; i++) {
              mC[r][c] += mA[r][i] * mB[i][c];
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
    static void ShowMatrix(int[][] m) {
      for (int r = 0; r < m.Length; r++) {
        for (int c = 0; c < m[0].Length; c++) Console.Write("\t{0}",m[r][c]);
        Console.WriteLine();
      }
      Console.WriteLine();
    }
  }
}
