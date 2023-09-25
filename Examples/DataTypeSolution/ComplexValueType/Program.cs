using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComplexValueType {
  class Point {
    internal long x;
    internal long y;
    public Point(long x, long y) {
      this.x = x;
      this.y = y;
    }
  }
  class Rectangle {
    Point p1;
    Point p2;
    public Rectangle(long x1,long y1,long x2,long y2) {
      p1.x = Math.Min(x1, x2);
      p1.y = Math.Min(y1, y2);
      p2.x = Math.Max(x1, x2);
      p2.y = Math.Max(y1, y2);
    }
    public long getWidth() {
      return p2.x - p1.x;
    }
    public long getHeight() {
      return p2.y - p1.y;
    }
    public long getArea() {
      return getWidth() * getHeight();
    }
    public long getCircumference() {
      return 2 * (getWidth() + getHeight());
    }
  }

  class Program {
    static void Main(string[] args) {
      Rectangle r1 = new Rectangle(10, 20, 50, 60);
      Rectangle r2 = r1;
    }
  }
}
