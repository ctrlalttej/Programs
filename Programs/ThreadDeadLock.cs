using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs
{
    class Account
    {
        public int Id { get; set; } 
        public decimal Balance { get; set; }
        public Account()
        {

        }

        public Account(int id)
        {
            this.Id = id;
        }
    }
    internal class ThreadDeadLock
    {
        static Account AccountA = new Account(1) { Balance=1000};
        static Account AccountB = new Account(2) { Balance=2000};

        public static void TransferAccountAToB(decimal  amount)
        {
            lock(AccountA)
            {
                Console.WriteLine("Transferring A to B");
                lock(AccountB)
                {
                    AccountA.Balance-=amount;
                    Console.WriteLine("Money Transfered A to B");
                }
            }
        }
        public static void TransferAccountBToA(decimal amount)
        {
            lock (AccountB)
            {
                Console.WriteLine("Transferring A to B");
                lock (AccountA)
                {
                    AccountB.Balance -= amount;
                    Console.WriteLine("Money Transfered A to B");
                }
            }
        }


        public static void UsingMonitor(decimal amount)
        {
            lock(AccountA)
            {
                if(Monitor.TryEnter(AccountB,300))
                {
                    AccountA.Balance -= amount;
                }
                else
                {
                    Console.WriteLine("Not able enter thread is blocked");
                }
            }
        }
        public static void Main()
        {
            new Thread(() => { UsingMonitor(5000); }).Start();
            new Thread(() => { UsingMonitor(3000); }).Start();
        }
    }
}
