using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lambda03 {
  class Program {
    static void Main(string[] args) {
      var employees = new[]{
        new {Name="Ali",      Age=24},
        new {Name="Abu",      Age=20},
        new {Name="Ahmad",    Age=28},
        new {Name="Azizi",    Age=18},
        new {Name="Abdullah", Age=25},
      };
      Console.WriteLine("--------Approach-1-----------");
      var youngEmployees = employees.Where(e=>e.Age < 21)
                           .Select(e=>new{e.Name});
      youngEmployees.ToList().ForEach(e => Console.WriteLine(e.Name));

      Console.WriteLine();

      Console.WriteLine("--------Approach-2-----------");
      var youngEmployees2 = from e in employees
                            where e.Age < 21
                            select new{e.Name};
      youngEmployees2.ToList().ForEach(e => Console.WriteLine(e.Name));

      Console.ReadKey();
    }
  }
}
