using System;
using System.Collections.Generic;

namespace ProjListGeneric {
  delegate bool FilterMethod(Object obj);

  class MyList<T> {
    List<T> items;
    public MyList() {
      items = new List<T>();
    }
    public MyList(int n) {
      items = new List<T>(n);
    }
    public int Count {
      get { return items.Count; }
    }
    public bool isEmpty {
      get { return items.Count == 0; }
    }
    public void Add(T item) {
      items.Add(item);
    }
    public T RemoveAt(int idx) {
      T item = items[idx];
      items.RemoveAt(idx);
      return item;
    }
    public void Insert(int idx, T item) {
      items.Insert(idx, item);
    }
    public void Clear() {
      items.Clear();
    }
    public T this[int idx] {
      get {
        return items[idx];
      }
      set {
        items[idx] = value;
      }
    }
    public T this[string nm] {
      get {
        switch (nm.ToUpper()) {
          case "FIRST": return items[0];
          case "LAST": return items[items.Count - 1];
        }
        throw new Exception("Invalid option:" + nm);
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
    public IEnumerable<T> Filter(FilterMethod fm) {
      foreach (T item in items) {
        if (fm(item)) yield return item;
      }
    }
  }
}
