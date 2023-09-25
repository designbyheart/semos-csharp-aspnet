using System;

namespace CircleClass {
 class Circle {
    double r;
    public Circle(double radius) {
      r = 0;
      Radius = radius;
    }
    //public Circle() : this(0.0) {
    //}
    public double Area {
      get { return Math.PI * r * r; }
    }
    public double Circumference {
      get { return 2*Math.PI * r; }
    }
    public double Radius {
      get { return r; }
      set {
        if (value < 0) 
          throw new Exception("Radius can't be negative!");
        r = value;
      }
    }
  }

  class Program {
    static void Main(string[] args) {
      Circle c = new Circle(10);
      Circle c2 = c;
      Console.Write("New Radius>>");
      double r = double.Parse(Console.ReadLine());
      c2.Radius = r;
      Console.WriteLine("Radius={0:f4}", c.Radius);
      Console.WriteLine("Area={0:f4}", c.Area);
      Console.WriteLine("Circumference={0:f4}", c.Circumference);
      Console.ReadKey();
    }
  }
}
