using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0102{
  static class Utils{
    static public bool isCountryCode(this string code){
      string[] codes = { "jp", "cn", "my", "uk", "in" };
      foreach (var c in codes) if (c.Equals(code)) return true;
      return false;
    }
  }
  internal class Program {
    static void Main(string[] args){
      Console.WriteLine("{0}", Utils.isCountryCode("my"));
      Console.WriteLine("{0}", "my".isCountryCode());
      Console.ReadKey();
    }
  }
}
