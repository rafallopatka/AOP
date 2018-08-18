using System;

namespace CustomAdvices
{
    class FooService
    {
        [TransactionalAdvice]
        public void Execute(SqlConntection connection = null)
        {
            Console.WriteLine(connection.ConnectionString);   
        }
    }


    class SqlConntection
    {
        public string ConnectionString { get; set; }

        public SqlConntection()
        {
            ConnectionString = "Foo";
        }
    }
}
