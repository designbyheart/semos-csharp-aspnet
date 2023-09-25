using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0103{
  internal class Clerk:Staff{
    public ushort OTHours;
    public float OTRate;
    public Clerk(string name, double salary, float oTRate, ushort oTHours=0)
      :base(name,salary) {
      OTRate = oTRate;
      OTHours = oTHours;
    }
    override public double getMonthlySalary() //Operation
    {
      return (1.0 - 0.11) * Salary + (OTHours * OTRate);//Method
    }
  }
}
