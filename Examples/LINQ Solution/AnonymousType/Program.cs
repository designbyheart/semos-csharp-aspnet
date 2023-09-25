using System;

namespace AnonymousType {
  class Program {
    static void Main(string[] args) {
      var rec = new { Name = "Ali", Age = 21 };
      Console.WriteLine(rec);
      Console.WriteLine("Name:{0}  Age:{1}",rec.Name,rec.Age);

      var recs = new[] { 
        new {Name="Abu",  Age=22},
        new {Name="Ahmad",Age=28},
      };

      foreach (var r in recs) Console.WriteLine(r);

      //Compiler optimization:
      //  Within the same program, 2 anonymous object initializers
      //  that specify a sequence of properties of the same name and
      //  compile-time types in the same order will produce instances
      //  of the same anonymous type.
      var rec2 = new { Name = "Azizi", Age = 20 };
      rec = rec2; //OK!
      var rec3 = new { Age = 20, Name = "Abdullah"};
      //rec = rec3; //Not OK!

      Console.ReadKey();
    }
  }
}
