using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjIEnumeratable {
  public class MyCollection<T> : IEnumerable<T> {
    private T[] _people;
    public MyCollection(T[] pArray) {
      _people = new T[pArray.Length];

      for (int i = 0; i < pArray.Length; i++) {
        _people[i] = pArray[i];
      }
    }

    // Implementation for the GetEnumerator method.
    IEnumerator<T> IEnumerable<T>.GetEnumerator() {
      return (IEnumerator<T>)GetEnumerator();
    }

    public CollectionEnum<T> GetEnumerator() {
      return new CollectionEnum<T>(_people);
    }

    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() {
      throw new NotImplementedException();
    }
  }

  // When you implement IEnumerable, you must also implement IEnumerator. 
  public class CollectionEnum<T> : IEnumerator<T> {
    public T[] _list;

    // Enumerators are positioned before the first element 
    // until the first MoveNext() call. 
    int position = -1;

    public CollectionEnum(T[] list) {
      _list = list;
    }

    public bool MoveNext() {
      position++;
      return (position < _list.Length);
    }

    public void Reset() {
      position = -1;
    }

    T IEnumerator<T>.Current {
      get {
        try {
          return _list[position];
        } catch (IndexOutOfRangeException) {
          throw new InvalidOperationException();
        }
      }
    }

    public void Dispose() {
      throw new NotImplementedException();
    }

    T System.Collections.IEnumerator.Current {
      get { throw new NotImplementedException(); }
    }
  }

}
