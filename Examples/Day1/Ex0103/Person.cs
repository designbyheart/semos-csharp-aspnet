using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0103 {
  internal class Person:Object {
    public string Name;
    public Person(string name) {
      Name = name;
      /*Another 100 lines of common initialization*/
    }
    public Person() : this("") { }
  }
}
