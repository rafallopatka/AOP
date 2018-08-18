using System;
using System.Transactions;

namespace TestCache
{
    class Program
    {
        static void Main(string[] args)
        {
            long i = 5;

            using (var transactionScope = new TransactionScope())
            {
                i = 10;

            }

            Console.WriteLine(i);
            Console.ReadLine();
        }
    }
}
