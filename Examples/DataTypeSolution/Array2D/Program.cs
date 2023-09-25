using System;

namespace Array2D {
  class Program {
    static void Main(string[] args) {
      int[,] grid1 = new int[2, 3];
      int[,] grid2 = new int[,]{
                      {1,2},
                      {3,4},
                      {5,6},
                      };
      int[,] grid3 = { { 1, 1 }, { 2, 2 }, { 3, 3 } };
      int x = 3, y = 4;
      grid1 = new int[x, y];
      grid2 = new int[,] { { 1, 1, 1 }, { 2, 2, 2 } };
      Console.WriteLine("Total items in the array is {0}", grid2.Length);
      Console.WriteLine("The dimension of array is {0}", grid2.Rank);
      Console.WriteLine("The length of 1st dimension (No of rows) {0}", grid2.GetLength(0));
      Console.WriteLine("The length of 2nd dimension (No of Cols) {0}", grid2.GetLength(1));
      ShowArray(grid2);
      Console.ReadKey();
    }
    static void ShowArray(int[,] arr2D) {
      for (int r = 0; r < arr2D.GetLength(0); r++) {
        for (int c = 0; c < arr2D.GetLength(1); c++) {
          Console.Write("\t{0}",arr2D[r,c]);
        }
        Console.WriteLine();
      }
      Console.WriteLine();
    }
  }
}
