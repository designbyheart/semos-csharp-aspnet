using System;

namespace ValueVsReference {
  class Circle {
    private double r;
    public Circle(double radius) {
      Radius = radius;
    }
    public double Radius{
      get {
        return r;
      }
      set {
        if (value < 0) throw new Exception("Radius can't be -ve!");
        r = value;
      }
    }
    public double Area {
      get {
        return Math.PI * r * r;
      }
    }
    public double Circumference {
      get {
        return 2 * Math.PI * r;
      }
    }
    public override bool Equals(object obj) {
      return this.r == ((Circle)obj).r;
    }
    static public bool operator ==(Circle lhs, Circle rhs) {
      return lhs.r == rhs.r;
    }
    static public bool operator !=(Circle lhs, Circle rhs) {
      return lhs.r != rhs.r;
    }
  }

  class Program {
    static void Main(string[] args) {
      Circle c1 = new Circle(100);
      Circle c2 = c1;
      Circle c3 = new Circle(100);

      //Reference Equality: Are those references referring to same object
      Console.WriteLine("c1==c2 is " + (c1 == c2));
      Console.WriteLine("c1==c3 is " + (c1 == c3));
      Console.WriteLine("Circle.ReferenceEquals(c1,c3) is " + Circle.ReferenceEquals(c1,c3));

      //Value Equality: Are those objects referred by the references having same value
      Console.WriteLine("c1.Equals(c2) is " + c1.Equals(c2));
      Console.WriteLine("c1.Equals(c3) is " + c1.Equals(c3));


      //c1.Radius = 200;
      //Console.WriteLine("c1.Radius={0}", c1.Radius);
      //Console.WriteLine("c1.Area={0}", c1.Area);
      //Console.WriteLine("c1.Circumference={0}", c1.Circumference);

      //Console.WriteLine("c2.Radius={0}", c2.Radius);
      //Console.WriteLine("c2.Area={0}", c2.Area);
      //Console.WriteLine("c2.Circumference={0}", c2.Circumference);
      Console.ReadKey();
    }
  }
}
