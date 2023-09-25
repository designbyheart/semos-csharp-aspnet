using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQAnonymousType {
  class Program {
    private static List<Customer> GetCustomers() {
      return new List<Customer>{
        new Customer { CustomerID="001", Name="Ali",   Age=20},
        new Customer { CustomerID="002", Name="Abu",   Age=25},
        new Customer { CustomerID="003", Name="Ahmad", Age=18},
      };
    }
    static void Main(string[] args) {
      var cs = from c in GetCustomers() where c.Age < 21 select c;
      foreach (Customer c in cs) Console.WriteLine(c.Name);

      Console.WriteLine("\nUse Anonymous Type:");
      var cs2 = from c in GetCustomers() where c.Age < 21 select new { ID=c.CustomerID, Name=c.Name};
      foreach (var c in cs2) Console.WriteLine(c);

      Console.WriteLine("\nUse Anonymous Type (Derived Name):");
      var cs3 = from c in GetCustomers() where c.Age < 21 select new { c.CustomerID, c.Name };
      foreach (var c in cs3) Console.WriteLine(c);

      Console.ReadKey();
    }
  }
}
