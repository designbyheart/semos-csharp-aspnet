using System;
using System.Linq;
using System.Collections.Generic;

namespace ExtensionMethod {
  static class Utils {
    //public static bool IsCountryCode(this string source) {
    public static bool IsCountryCode(this string source) {
        string[] codes ={
                       "my",
                       "cn",
                       "jp",
                       "us",
                     };
      if(source==null) return false;
      source = source.ToLower();
      foreach (string s in codes) if (source == s) return true;
      return false;
    }
    public static T FirstX<T>(this T[] items, Predicate<T> found) {
      foreach (T item in items) {
        if (found(item)) return item;
      }
      throw new InvalidOperationException("Sequence contains no matching element");
    }
    //public static List<T> Filter<T>(this T[] items, Predicate<T> accept) {

    public static List<T> Filter<T>(this IEnumerable<T> items, Predicate<T> accept) {
      List<T> result = new List<T>();
      foreach (T item in items) {
        if (accept(item)) {
          Console.Write("#");
          result.Add(item); 
        }
      }
      return result;
    }
    public static IEnumerable<T> FilterX<T>(this IEnumerable<T> items, Predicate<T> accept) {
      foreach (T item in items) {
        if (accept(item)) {
          Console.Write("*");
          yield return item;
        }
      }
    }
  }

  class Program {
    static void showTest(string code) {
      string format = "You entered: {0}. It is country code: {1}";
      Console.WriteLine(format, code, Utils.IsCountryCode(code));
      Console.WriteLine(format, code, code.IsCountryCode());
    }
    static void Main(string[] args) {
      //showTest("my");
      
      int[] data = { 6, 2, 3, 4, 5 };
      /*
      try {
        //int i;
        //for (i = 0; i < data.Length; i++) {
        //  if ((data[i] % 2) != 0) break;
        //}
        //if (i == data.Length)
        //  throw new InvalidOperationException("Sequence contains no matching element");
        //int odd = data[i];
        //var odd = data.FirstX(x => (x % 2) != 0);
        var odd = Utils.FirstX(data, x => (x % 2) != 0);
        Console.WriteLine("The first odd number is " + odd);
      } 
      catch(Exception ex){
        Console.WriteLine(ex.Message);
      }
      */
      foreach(var odd in data.Filter(x => (x % 2) != 0)) {
        Console.WriteLine(odd);
      }
      Console.WriteLine();
      //double[] values = { 1.2, -3.5, 4.6, -3.3, 0, 5};
      List<double> values = new List<double>() { 1.2, -3.5, 4.6, -3.3, 0, 5};
      List<double> itemsPos = values.Filter(x => x >= 0);
      foreach (var pos in itemsPos) {
        Console.WriteLine(pos);
      }
      Console.WriteLine();
      foreach (var pos in values.FilterX(x => x>=0)) {
        Console.WriteLine(pos);
      }

      Console.ReadKey();
    }
  }
}
