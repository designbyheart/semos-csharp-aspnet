using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQWhereClause {
  class Program {
    static void Main(string[] args) {

      Console.WriteLine("Small Data:");
      List<int> data = new List<int>() { 1, 2, 3, 4, 5 };
      var query = from item in data
                  where item < 3
                  select item;
      foreach (int item in query) Console.WriteLine(item);


      List<string> days = new List<string>(){
        "Sunday",
        "Monday",
        "Tuesday",
        "Wednesday",
        "Thursday",
        "Friday",
        "Saturday",
      };
      var SDays = from day in days
                  where day.StartsWith("S")
                  select day;
      Console.WriteLine("\nDays start with \"S\":");
      foreach (string sDay in SDays) Console.WriteLine(sDay);

      Console.WriteLine("\nDays contain \"es\":");
      var esDays = from day in days
                   where day.Contains("es")
                   select day;
      foreach (string sDay in esDays) Console.WriteLine(sDay);

      Console.ReadKey();
    }
  }
}
