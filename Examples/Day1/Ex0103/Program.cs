//#define ABSTRACT
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0103{
  internal class Program{

#if ABSTRACT
    static void ShowManagerInfo(Manager m) {
      Console.WriteLine("{0,-12} {1:c}", m.Name, m.getMonthlySalary());
    }

    static void Main(string[] args){
      //Staff staff = new Staff("Alibaba", 8888);


      Manager m = new Manager("Ahmad", 5000, 600);
      HRManager hrm = new HRManager("Abu", 5000);
      SalesManager sm = new SalesManager("Ali", 5000, 600, 800);

      ShowManagerInfo(m);

      ShowManagerInfo(hrm);

      sm.MonthlySales = 100_000;
      ShowManagerInfo(sm);

      Console.ReadKey();
    }
#else
    static void ShowAllStaffInfo(Staff[] allStaff) {
      foreach(var staff in allStaff) {
        Console.WriteLine("Name:{0,-12} Monthly Salary:{1:c}",
          staff.Name,staff.getMonthlySalary());
      }
      Console.WriteLine();
    }
    static void Sort(ISortable[] items, object sortCriteria) {
      int n = items.Length;
      for(int x=0; x<(n-1); x++) {
        for (int y = 0; y < (n - 1 - x); y++) {
          if (items[y].Swap(items[y+1],sortCriteria)) {
            ISortable item = items[y];
            items[y] = items[y + 1];
            items[y+1] = item;
          }
        }
      }
    }

    static void Main(string[] args){
      Staff[] staff2023 = new Staff[] {
        new Lecturer("Peter", 2500, 450),
        new Clerk("Mary", 1800,15),
        new Manager("Ahmad", 5000, 600),
        new HRManager("Abu", 4500),
        new SalesManager("Ali",5000, 600, 800),
      };

      ShowAllStaffInfo(staff2023);
      Sort(staff2023, Staff.SortCriteria.ByMonthlySalary);
      ShowAllStaffInfo(staff2023);
      Sort(staff2023, Staff.SortCriteria.ByMonthlySalaryDesc);
      ShowAllStaffInfo(staff2023);
      Sort(staff2023, Staff.SortCriteria.ByName);
      ShowAllStaffInfo(staff2023);

      Console.ReadKey();
    }
#endif
  }
}
