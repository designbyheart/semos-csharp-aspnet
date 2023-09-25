using System;
using System.Collections.Generic;

namespace ProjMyList {
  class MyList {
    List<int> items;
    public MyList() {
      items = new List<int>();
    }
    public MyList(int n) {
      items = new List<int>(n);
    }
    public int Count {
      get { return items.Count; }
    }
    public bool isEmpty{
      get{ return items.Count==0;}
    }
    public void Add(int item) {
      items.Add(item);
    }
    public int RemoveAt(int idx) {
      int item = items[idx];
      items.RemoveAt(idx);
      return item;
    }
    public void Insert(int idx, int item) {
      items.Insert(idx, item);
    }
    public void Clear() {
      items.Clear();
    }
    public int this[int idx] {
      get {
        return items[idx];
      }
      set {
        items[idx] = value;
      }
    }
    public int this[string nm] {
      get{
        switch(nm.ToUpper()){
          case "FIRST": return items[0];
          case "LAST": return items[items.Count-1];
        }
        throw new Exception("Invalid option:"+nm);
      }
      set {
        switch (nm.ToUpper()) {
          case "FIRST": 
            items[0] = value;
            break;
          case "LAST": 
            items[items.Count - 1] = value;
            break;
          default:
            throw new Exception("Invalid option:" + nm);
        }
      }
    }
    static bool isPrime(int n) {
      int i;
      n = Math.Abs(n);
      for (i = 2; (i < n)&&((n % i) != 0); i++);
      return (i == n);
    }
    public IEnumerable<int> Odds {
      get {
        foreach (int item in items) {
          if ((item % 2) != 0) yield return item;
        }
      }
    }
    public IEnumerable<int> Evens {
      get {
        foreach (int item in items) {
          if ((item % 2) == 0) yield return item;
        }
      }
    }
    public IEnumerable<int> Primes {
      get {
        foreach (int item in items) {
          if (isPrime(item)) yield return item;
        }
      }
    }
  }
}
