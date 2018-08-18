using System;

namespace CustomAdvices
{
    class Program
    {
        static void Main(string[] args)
        {
           // PintTest();
            ConntectionTest();
            Console.ReadLine();
        }

        private static void ConntectionTest()
        {
           var service = new FooService();

            service.Execute();
        }

        private static void PintTest()
        {
            PingMachine pingMachine = new PingMachine();
            pingMachine.MakePing(10);
            pingMachine.MakePing(-10);
            pingMachine.MakePing(0);

            Console.WriteLine("TEST 2");

            pingMachine.MakePing(10, "SPAM");
            pingMachine.MakePing(-10, "SPAM");
            pingMachine.MakePing(0, "SPAM");
        }
    }
}
