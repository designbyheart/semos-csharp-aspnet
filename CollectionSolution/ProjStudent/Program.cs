using System;
using System.Collections;
namespace ProjStudent {
  class Student {
    public readonly String Name;
    public float CGPA;
    public Student(String name, float cgpa) {
      Name = name;
      CGPA = cgpa;
    }
    public void Show() { Console.WriteLine("CGPA:{1:f1} Name:{0}", Name, CGPA); }
  }
  class Program {
    static void SortStudentByName(ArrayList items) {
      int n = items.Count;
      for (int x = 0; x < (n - 1); x++) {
        for (int y = 0; y < (n - 1 - x); y++) {
          if(((Student)items[y]).Name.CompareTo(((Student)items[y+1]).Name)>0){
            Student student = (Student)items[y];
            items[y] = items[y + 1];
            items[y+1] = student;
          }
        }
      }
    }
    static void Main(string[] args) {
      ArrayList students = new ArrayList();
      while (true) {
        Console.Write("Name:>>");
        String name = Console.ReadLine().Trim().ToUpper();
        if(name=="") break;
        Console.Write("CGPA:>>");
        float cgpa = float.Parse(Console.ReadLine());
        students.Add(new Student(name, cgpa));
      }
      Console.WriteLine("------------ Students Info -------------------");
      SortStudentByName(students);
      foreach (Student s in students) s.Show();
      Console.ReadKey();
    }
  }
}
