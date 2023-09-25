using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queens {
  internal class Program {
    static int[] Qs = new int[8];
    static int Row = 0;
    static uint NoOfAnswers = 0;
    static void ShowAnswer() {
      for(int r = 0; r < 8; r++) {
        for (int c = 0; c < 8; c++) Console.Write((Qs[r] == c)?'♕':'.');
        Console.WriteLine();
      }
      Console.WriteLine();
    }
    static bool IsValidColumn(int c) {
      for(int r = 0; r < Row; r++) {
        //Vertical Check
        if (c == Qs[r]) return false;

        //Diagonal Check
        int dR = Row - r;
        int dC = c - Qs[r];
        if (dC < 0) dC = -dC;
        if (dR==dC) return false;
      }
      return true;
    }
    static void Solve() {
      if (Row < 8) {
        for(int c=0;c<8; c++) {
          if (IsValidColumn(c)) {
            Qs[Row] = c;
            Row++;
            Solve();  //Recursion
            Row--;    //Backtracking
          }
        }
      } else {
        NoOfAnswers++;
        ShowAnswer();
      }
    }
    static void Main(string[] args) {
      Console.OutputEncoding = System.Text.Encoding.UTF8;
      Solve();
      Console.WriteLine("No of answers found is {0}",NoOfAnswers);
      Console.ReadKey();
    }
  }
}