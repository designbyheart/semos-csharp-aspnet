using System;

namespace ProjIEnumeratable {
  class Program {
    static void Main() {
      Person[] peopleArray = new Person[3]{
            new Person("John", "Smith"),
            new Person("Jim", "Johnson"),
            new Person("Sue", "Rabon"),
        };

      MyCollection peopleList = new MyCollection(peopleArray);
      foreach (Person p in peopleList) Console.WriteLine(p.firstName + " " + p.lastName);
      Console.ReadKey();
    }
  }
}
