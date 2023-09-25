using System;

namespace DefaultValue {
  class Program {
    static int Add(int x, int y = 0, int z = 0) {
      return (x + y + z);
    }
    //static int Add(int x, int y, int z) {
    //  return (x + y + z);
    //}
    //static int Add(int x, int y) {
    //  return (x + y);
    //}
    //static int Add(int x) {
    //  return (x);
    //}
    static void Main(string[] args) {
      Console.WriteLine("Add(1,2,3)={0}", Add(1, 2, 3));
      Console.WriteLine("Add(1,2)={0}", Add(1, 2));
      Console.WriteLine("Add(1)={0}", Add(1));
      Console.ReadKey();
    }
  }
}
