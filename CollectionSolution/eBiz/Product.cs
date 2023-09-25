using System;

namespace eBiz {
    abstract class Product {
        public string Name;
        public float Price;
        public Product(string name, float price) {
            Name = name;
            Price = price;
        }
        abstract public string Code { get; }
    }
}
