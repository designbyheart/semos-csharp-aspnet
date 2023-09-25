using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQObjectInitializer {
  class Student {
    public String Name;
    public float CGPA;
    public int Age;
    public Student(String name) {
      Name = name;
    }
  }
  class Program {
    static void Main(string[] args) {
      Student s = new Student("Ali");
      s.Age = 18;
      s.CGPA = 3.2F;
      Console.WriteLine("Name:{0} Age:{1} CGPA:{2}", s.Name, s.Age, s.CGPA);
      s = new Student("Abu") { Age = 20 , CGPA= 2.6F};
      Console.WriteLine("Name:{0} Age:{1} CGPA:{2}", s.Name, s.Age, s.CGPA);
      Console.ReadKey();
    }
  }
}
