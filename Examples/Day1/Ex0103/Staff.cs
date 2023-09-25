using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0103 {
  internal abstract class Staff:Person,ISortable {
    public double Salary;
    public Staff(string name, double salary):base(name) {
      if (salary < 1500) throw new Exception("Salary too low!");
      Salary = salary;
    }

    abstract public double getMonthlySalary();//Operation

    public enum SortCriteria { 
      ByName, ByNameDesc,
      ByMonthlySalary, ByMonthlySalaryDesc,
    }

    public bool Swap(object obj, object sortCriteria) {
      Staff lhs = this;
      Staff rhs = obj as Staff;
      switch ((SortCriteria)sortCriteria) {
        case SortCriteria.ByName: return lhs.Name.CompareTo(rhs.Name) > 0;
        case SortCriteria.ByNameDesc: return lhs.Name.CompareTo(rhs.Name) < 0;
        case SortCriteria.ByMonthlySalary:
          return lhs.getMonthlySalary() > rhs.getMonthlySalary();
        case SortCriteria.ByMonthlySalaryDesc:
          return lhs.getMonthlySalary() < rhs.getMonthlySalary();
      }
      throw new NotImplementedException("Missed case:" + sortCriteria);
    }
  }
}
