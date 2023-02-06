using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructure_Program.Utility
{
    internal class BankingCashCounter
    {
        CashQueue<string> queue;
        int totalAmount;
        public void ReadAllTextFile(string filepath)
        {
            string line = File.ReadAllText(filepath);
            string[] names = line.Split(",");
            queue = new CashQueue<string>();
            foreach (var name in names)
            {
                queue.Enqueue(name);
            }
            queue.Display();
            Console.Write("Total amount avilable in Cash Counter initialy :");
            totalAmount = Convert.ToInt32(Console.ReadLine());
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("~~~~~~~Wellcome to Cash Counter~~~~~~~");
                Console.WriteLine("\nselect what you want to do : \n 1.Deposite Cash \n 2.Withdrow Cash \n 3.Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        Deposit();
                        break;
                    case 2:
                        Withdraw();
                        break;
                    case 3:
                        flag = false;
                        break;
                }
            }
            Console.WriteLine("Cash remaining at Cash counter is : " + totalAmount);
        }
        public void Deposit()
        {
            Console.Write("Enter the amount you want to Deposit: ");
            int deposit = Convert.ToInt32(Console.ReadLine());
            totalAmount += deposit;
            queue.Dequeue();
        }
        public void Withdraw()
        {
            Console.Write("Enter the amount you want to Withdraw: ");
            int withdraw = Convert.ToInt32(Console.ReadLine());
            if (totalAmount > withdraw)
            {
                if (withdraw <= 40000)
                {
                    totalAmount -= withdraw;
                    queue.Dequeue();
                }
                else
                {
                    Console.WriteLine("Limit Exceeds.Try Again");
                    Withdraw();
                }
            }
            else
            {
                Console.WriteLine("Insufficient balance in ATM.Please select less amount");
                Withdraw();
            }
        }
    }
}
