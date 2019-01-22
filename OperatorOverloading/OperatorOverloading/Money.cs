using System;
using System.Collections.Generic;
using System.Text;

namespace OperatorOverloading
{
    class Money
    {

        //public int Balance { get; set; }
        //public string Name { get; set; }

        //public Money(string name, int balance)
        //{
        //    Balance = balance;
        //    Name = name;
        //}

        //public override string ToString()
        //{
        //    return Name + " " + Balance.ToString();
        //}

        //public static Money operator ++(Money a)
        //{
        //    Money b = new Money("operator ++", a.Balance);
        //    a.Balance += 1;
        //    return b;
        //}

        public double Balance { get; set; }

        public Money(double balance)
        {
            Balance = balance;
        }


        public static Money operator ++(Money a)
        {
           // Money b = new Money(a.Balance);
            a.Balance ++;
            return a;
        }
        //    public Money(double salary)
        //    {
        //        Salary = salary;
        //    }

        //    public double Salary { get; set; }
        //}

        //public static Money operator ++(Money a)
        //{
        //    Money b = new Money(a.Salary);
        //    a.Salary += 1;
        //    return b;
    }
    
}
