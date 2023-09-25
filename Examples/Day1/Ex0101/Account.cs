using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ex0101{
  internal class Account{
    public double Balance;
    static public float InterestRate=0.05F;
    static Account(){
      Console.Write("Rate?>>");
      InterestRate = float.Parse(Console.ReadLine());

    }
    public Account(double initAmount){
      Balance = initAmount;
    }
    public Account():this(0){
    }

    public void Withdraw(double amount){
      Balance -= amount;
    }
    public void Deposit(double amount){
      Balance += amount;
    }
    public void Update(){
      Balance *= (1.0 + InterestRate);
    }
    static public void PurgeInactiveAccounts(){
      InterestRate = 0.01F;
      //The method goes here...
    }
  }
}
