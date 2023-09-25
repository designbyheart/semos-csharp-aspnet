using System;
using System.Diagnostics;

namespace NullableType {
  class Program {
    static void Main(string[] args) {
      float? examResult=null;

      float result = examResult??0;

      //float result = examResult.HasValue ? examResult.Value : 0;

      //if (examResult.HasValue) {
      //  result = examResult.Value;
      //} else {
      //  result = 0.0f;
      //}


      Console.ReadKey();
    }
  }
}
