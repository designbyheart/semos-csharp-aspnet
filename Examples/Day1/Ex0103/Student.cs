using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0103{
  internal class Student:Person{
    public float CGPA;
    public Student(string name, float cgpa):base(name) {
      CGPA = cgpa;
    }
  }
}
