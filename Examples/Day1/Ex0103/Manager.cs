using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0103 {
  internal class Manager:Staff {
    public float CarAllowance;
    public Manager(string name, double salary, float carAllowance):
      base(name, salary){
      CarAllowance = carAllowance;
    }

    override public double getMonthlySalary() //Operation 
    {
      return (1.0 - 0.11) * Salary + CarAllowance; //Method
    }
  }
}
