using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;

namespace TPL02 {
  class Program {
    public static void Main(string[] args){
      //Create a collection of strings
      List<string> fruits=new List<string>{
        "ciku","rambutan","durian","nenas","langsat" 
      };

      //Process the elements of the collection using parellel foreach loop  
      Parallel.ForEach(fruits, fruit=>{
        Thread.Sleep(500);
        Console.WriteLine("Fruit \"{0}\" has {1} letters",
	        fruit, fruit.Length);
      });
      Console.ReadKey();
    }
  }
}