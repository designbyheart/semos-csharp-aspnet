using System;


namespace eBiz {
    class CartItem<T> where T : Product {
        public T Item;
        uint _Quantity;
        public uint Quantity { 
            get { return _Quantity; }
            private set {
               _Quantity = value;
            } 
        }
        public CartItem(T item, uint quantity = 1){
            Item = item;
            Quantity = quantity;
        }
        public float SubTotal { get { return Item.Price * _Quantity; } }
        public void Increase(uint n = 1) {
            Quantity += n;
        }
        public bool Decrease(uint n = 1) {
            if (n > _Quantity) return false;
            Quantity -= n;
            return true;
        }
    }
}
