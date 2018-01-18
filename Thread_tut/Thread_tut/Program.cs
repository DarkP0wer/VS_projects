using System;
using System.Collections.Generic;
using System.Threading;
using System.IO;

namespace Thread_tut
{
    class BankAcct
    {
        private Object acctLock = new object();
        Double Balance { get; set; }

        public BankAcct(Double bal)
        {
            Balance = bal;

        }


        public double Withdraw(Double amt)
        {
            if ((Balance - amt) < 0)
            {
                Console.WriteLine($"Sorry ${Balance} in Account");
                return Balance;

            }
            lock (acctLock)
            {
                if(Balance >= amt)
                {
                    Console.WriteLine("Removed {0} and {1} lef in Accoubt", amt, (Balance - amt));
                    Balance -= amt;
                }
                return Balance;
            }
        }

        public void IssueWidthraw()
        {
            Withdraw(1);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            BankAcct acct = new BankAcct(10);
            Thread[] threads = new Thread[15];

            Thread.CurrentThread.Name = "main";

            for(var i = 0; i < 15; i++)
            {
                Thread t = new Thread(new ThreadStart(acct.IssueWidthraw));
                t.Name = i.ToString();
                threads[i] = t;
            }

            for(var i = 0; i < 15; i++)
            {
                Console.WriteLine("Thread {0} Alive : {1}", 
                    threads[i].Name, 
                    threads[i].IsAlive);

                threads[i].Start();

                Console.WriteLine("Thread {0} Alive : {1}",
                    threads[i].Name,
                    threads[i].IsAlive);
            }

            Console.WriteLine("Current Prority : {0}", Thread.CurrentThread.Priority);
            Console.WriteLine("Thread {0} Ending", Thread.CurrentThread.Name);

            Thread t2 = new Thread(() => CountTo(10));
            t2.Start();

            new Thread(() =>
            {
                CountTo(5);
                CountTo(6);
            }).Start();

            Console.ReadKey();
        }


        static void CountTo(int maxNum)
        {
            for(var i = 0; i < maxNum; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
