using System;

namespace Univeristy {
  //delegate bool Swap<T>(T lhs, T rhs);

  class Program {
    static void Sort<T>(T[] items, Func<T, T, bool> swap) {
    //static void Sort<T>(T[] items, Swap<T> swap) {
      int n = items.Length;
      for(int x = 0; x < (n - 1); x++) {
        for (int y = 0; y < (n - 1 - x); y++) {
          if (swap(items[y],items[y + 1])) {
            T item = items[y];
            items[y] = items[y + 1];
            items[y + 1] = item;
          }
        }
      }
    }
    static void ShowAllStudentInfo(Student[] allStudents) {
      foreach(var student in allStudents) {
        Console.WriteLine("Name:{0,-12}CGPA:{1:F2}",student.Name,student.CGPA);
      }
      Console.WriteLine();
    }
    static bool ByCGPA(Student lhs, Student rhs) {
      return lhs.CGPA > rhs.CGPA;
    }
    static bool ByCGPADesc(Student lhs, Student rhs) {
      return lhs.CGPA < rhs.CGPA;
    }
    static bool ByName(Student lhs, Student rhs) {
      return lhs.Name.CompareTo(rhs.Name)>0;
    }

    static void Main(string[] args) {
      Student[] students = {
        new Student("Peter",  3.15F),
        new Student("Steven", 2.75F),
        new Student("Joe",    1.75F),
        new Student("Joan",   3.25F),
        new Student("Mary",   3.75F),
        new Student("Biden",  1.15F),
        new Student("Tiago",  3.05F),
      };
      ShowAllStudentInfo(students);
      Sort(students,ByCGPA);
      ShowAllStudentInfo(students);
      Sort(students, ByCGPADesc);
      ShowAllStudentInfo(students);
      Sort(students, ByName);
      ShowAllStudentInfo(students);

      Sort(students, delegate (Student lhs, Student rhs) {
        return lhs.Name.CompareTo(rhs.Name) > 0;
      }); //Anonymous Delegate
      ShowAllStudentInfo(students);

      Sort(students, (lhs, rhs) =>lhs.Name.CompareTo(rhs.Name) > 0); //Lambda Expression
      ShowAllStudentInfo(students);

      Console.ReadKey();
    }
  }
}
