using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex0101{
  internal static class Financial{//Pure utility class
    //private Financial() { }
    static public double FV(double pv, double r, int n){
      return pv * Math.Pow(1 + r, n);
    }
    static public double Pmt(double p, double r, int n){
      return p * (r * Math.Pow(1 + r, n)) / (Math.Pow(1 + r, n)-1);
    }
  }
}
