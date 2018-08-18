using System;
using System.Transactions;

namespace Aop.Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            var msg = $"{nameof(SubOperation1)} failed. Parameters: ";
            Console.WriteLine(msg);


            using (var transactionScope = new TransactionScope())
            {
                
            }

        }

        void SubOperation1()
        {
            
        }
    }
}
