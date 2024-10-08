﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    public class Bank
    {
        private decimal Balance;
        private string AccountName;

        public Bank(decimal startingmoney, string name)
        {
            Balance = startingmoney;
            AccountName = name;
        }

        public decimal GetBalance()
        {
            return Balance;
        }

        public string GetName()
        {
            return AccountName;
        }

        public void SetBalance(decimal value)
        {
            Balance = value;
        }
    }
    class Program
    {
        static void Main()
        {

            Console.Write("Enter new account-name input: ");
            string resultName = Console.ReadLine();

            Console.Write("Enter starting balance: ");
            int money = Convert.ToInt32(Console.ReadLine());

            Bank Bank = new Bank(money, resultName);

            Console.WriteLine("Balance: " + Bank.GetBalance());

        }
    }
}