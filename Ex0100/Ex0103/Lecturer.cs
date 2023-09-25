using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0103{
  internal class Lecturer:Staff{
    public float Allowance;
    public Lecturer(string name, double salary, float allowance):base(name,salary){
      Allowance = allowance;
    }
    override public double getMonthlySalary() //Operation
    {
      return (1.0 - 0.11) * Salary + Allowance;//Method
    }
  }
}
