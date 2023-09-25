using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0103 {
  internal class SalesManager:Manager {
    public float PetrolAllowance;
    public double MonthlySales;
    public SalesManager(string name, double salary, float carAllowance,
      float petrolAllowance,double monthlySales=0):
      base(name, salary, carAllowance) {
      PetrolAllowance = petrolAllowance;
      MonthlySales = monthlySales;
    }

    override public double getMonthlySalary() //Operation 
    {
      return (1.0 - 0.11) * (0.6 * Salary) + CarAllowance + 
        PetrolAllowance + (0.1*MonthlySales);                 //Method
    }

  }
}
