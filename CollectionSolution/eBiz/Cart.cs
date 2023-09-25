using System;
using System.Collections.Generic;

namespace eBiz {
  class Cart<T> where T : Product {
    List<CartItem<T>> Items = new List<CartItem<T>>();
    public void Add(T item, uint quantity = 1) {
      //var ci = Items.Find(cardItem => cardItem.Item.Code == item.Code);
      var ci = this[item.Code];
      if (ci != null) ci.Increase(quantity);
      else Items.Add(new CartItem<T>(item, quantity));
    }
    public void Remove(T item, uint quantity = 1) {
      //var ci = Items.Find(cardItem => cardItem.Item.Code == item.Code);
      var ci = this[item.Code];
      if (ci != null) {
        if (ci.Decrease(quantity)) {
          if (ci.Quantity == 0) Items.Remove(ci);
        }
      }
    }
    public float GrandTotal {
      get {
        float total = 0;
        foreach (var ci in Items) total += ci.SubTotal;
        return total;
      }
    }

    public CartItem<T> this[string code] {
      get {
        return Items.Find(cardItem => cardItem.Item.Code == code);
      }
    }
  }
}
