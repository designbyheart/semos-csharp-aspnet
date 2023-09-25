using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// base class name 'baseClass' 
class baseClass

{
    public virtual void show() // virtual je nedostajao u jucerasnjem primeru
    {
        Console.WriteLine("Base class");
    }
}

// derived class name 'derived' 
// 'baseClass' inherit here 
class derived : baseClass
{

    // overriding 
    public override void show()
    {
        Console.WriteLine("Derived class");
    }
}

class Card {
    public string Name { get; set; }
    public Card(string name) {
        Name = name;   
    }
}
class Deck
{
    private int MaximumNumberOfCards;

    public List<Card> Cards { get; set; }

    public Deck(int maximumNumberOfCards)
    {
        this.MaximumNumberOfCards = maximumNumberOfCards;
        Cards = new List<Card>();
        Card kingPik = new Card("kingPik");
        Console.WriteLine(kingPik.Name);
    }
    // Rest of the class
}


class GFG
{

    // Main Method 
    public static void Main()
    {

        // 'obj' is the object of 
        // class 'baseClass' 
        baseClass obj = new baseClass();


        // invokes the method 'show()' 
        // of class 'baseClass' 
        obj.show();

        obj = new derived();

        // it also invokes the method  
        // 'show()' of class 'baseClass' 
        obj.show();
    }
}