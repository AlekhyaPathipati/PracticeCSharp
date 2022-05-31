using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankProject
{
    public class Program
    {
        String Name;
        long PhoneNUmber;
        String Gender;
        int age;
       interface IBankAccount
        {
            abstract void debit(double d);
            abstract void Credit(double d);
        }
        public class BankAccount : IBankAccount
        {

            decimal AccountBalance;
            public BankAccount()
            {
                this.AccountBalance = 100;
            }
            public void Debit(decimal Amount)
            {
                if (Amount >= 0)
                {
                    Console.WriteLine("The amount you entered is Wrong!");
                    if (this.AccountBalance > Amount)
                    {
                        this.AccountBalance = this.AccountBalance - Amount;
                        Console.WriteLine("Trascation successfull");

                    }
                    else
                    {
                        Console.WriteLine("You dont have enough money to do this transcation");
                    }
                }
                Console.ReadLine();
            }
            public void credit(decimal Amount)
            {
                if (Amount >= 0)
                {
                    this.AccountBalance = this.AccountBalance + Amount;
                }
                else
                {
                    Console.WriteLine("Your Account has been credited successfully");
                }
                Console.ReadLine();
            }
            static void Main(string[] args)
            {
                BankAccount account = new BankAccount();
                account.credit(account.AccountBalance);
                account.Debit(account.AccountBalance);
                Console.WriteLine();
                Console.ReadLine();
            }
        }

    }
}
