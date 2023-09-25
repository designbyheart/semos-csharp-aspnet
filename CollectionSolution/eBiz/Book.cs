using System;

namespace eBiz {
    class Book : Product {
        public readonly string Author;
        public readonly string ISBN;
        public Book(string isbn, string title, string author, float price):
            base(title,price) {
            Author = author;
            ISBN = isbn;
        }
        public override string Code {
            get {
                return ISBN;
            }
        }
    }
}
