using System;

namespace ArrayOfArray {
  class Program {
    static void Main(string[] args) {
      int[][] data1 = new int[2][];
      int[][] data2 = new int[][] { 
                        new int[]{ 1, 2, 3 }, 
                        new int[]{ 2, 4 },
                      };
      int[] data = { 4, 4, 4 };
      int[][] data3 = { 
                        new int[]{ 1, 2, 3 }, 
                        new int[]{ 4, 5, 6 },
                        data,
                      };
    }
  }
}
