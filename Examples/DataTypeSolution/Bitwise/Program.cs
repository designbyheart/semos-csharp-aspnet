using System;

namespace Bitwise {
  internal class Program {
    static bool isWellFormed(int state) {
      int flags = 0x000001FF;
      for(int i = 0; i < 9; i++) {
        int digit = state % 10;
        flags &= ~(1 << digit);
        state /= 10;
      }
      return (flags==0)&&(state==0);
    }

    static void MainX(string[] args) {
      Console.WriteLine(isWellFormed(876543210)?"YES":"NO");
      Console.ReadKey();
    }








    static void ShowBits(string prompt, int bits32) {
      Console.Write(prompt);
      for(int i = 0; i < 32; i++) {
        Console.Write((bits32 & 0x80000000)==0?'0':'1');
        bits32 <<= 1;
      }
      Console.WriteLine();
    }
    static void Main(string[] args) {
      int x = 3, y = 5;
      ShowBits("x\t:", x);
      //ShowBits("y\t:", y);
      //ShowBits("x&y\t:", x & y); //AND
      //ShowBits("x|y\t:", x | y); //OR
      //ShowBits("x^y\t:", x ^ y); // XOR
      //ShowBits("x<<1\t:", x << 1);//Shift Left
      //ShowBits("x>>1\t:", x >> 1);//Signed Shift-Right
      //ShowBits("~x\t:", ~x);//Invertion
      int mask = 6;
      ShowBits("mask\t:", mask);//Mask
      //ShowBits("SET\t:", x | mask);// Set operation
      //ShowBits("TOG\t:", x ^ mask);// Toggle operation
      //ShowBits("CLR\t:", x & ~mask);// Clear operation

      if ((x & mask) != 0) Console.WriteLine("At least One of the bits is ON");
      if ((x & mask) == mask) Console.WriteLine("All the bits are ON");

      Console.ReadKey();
    }
  }
}
