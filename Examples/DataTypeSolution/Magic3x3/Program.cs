using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic3x3 {
  internal class Program {
    static int[] Slots = new int[9];
    static int Level = 0;
    static uint NoOfPatterns = 0;
    static uint NoOfAnswers = 0;
    static void Solve() {
      if (Level < 9) {//Generate
        for(int n=1; n <= 9; n++) {
          if (IsNotInUsed(n)) {
            Slots[Level] = n;
            Level++;
            Solve();  //Recursion
            Level--;  //Backtracking
          }
        }
      } else {//Test
        NoOfPatterns++;
        if (IsAnswer()) {
          NoOfAnswers++;
          ShowAnswer();
        }
      }
    }
    static void ShowAnswer() {
      Console.WriteLine("{0}{1}{2}", Slots[0], Slots[1], Slots[2]);
      Console.WriteLine("{0}{1}{2}", Slots[3], Slots[4], Slots[5]);
      Console.WriteLine("{0}{1}{2}", Slots[6], Slots[7], Slots[8]);
      Console.WriteLine();
    }
    static bool IsNotInUsed(int n) {
      for(int i=0;i<Level;i++)
        if (Slots[i] == n) return false;
      return true;
    }
    static bool IsAnswer() {
      //012
      //345
      //678
      int H1 = Slots[0] + Slots[1] + Slots[2];
      int H2 = Slots[3] + Slots[4] + Slots[5];
      int H3 = Slots[6] + Slots[7] + Slots[8];
      int V1 = Slots[0] + Slots[3] + Slots[6];
      int V2 = Slots[1] + Slots[4] + Slots[7];
      int V3 = Slots[2] + Slots[5] + Slots[8];
      int D1 = Slots[0] + Slots[4] + Slots[8];
      int D2 = Slots[2] + Slots[4] + Slots[6];
      return (H1 == H2) && (H1 == H3) && 
             (H1 == V1) && (H1 == V2) && (H1 == V3) &&
             (H1 == D1) && (H1 == D2);
    }
    static void Main(string[] args) {
      Solve();
      Console.WriteLine("No of Patterns examined is {0}", NoOfPatterns);
      Console.WriteLine("No of Answers found is {0}", NoOfAnswers);
      Console.ReadKey();
    }
  }
}
