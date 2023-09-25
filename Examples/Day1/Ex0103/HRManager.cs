using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0103 {
  internal class HRManager:Manager {
    public HRManager(string name, double salary) :
      base(name, salary, 500) { }
  }
}
