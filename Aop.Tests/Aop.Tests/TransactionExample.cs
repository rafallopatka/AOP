using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Transactions;

namespace Aop.Tests
{
    class TransactionExample
    {
        public int CreateTransactionScope(string connectString1, string connectString2, string commandText1, string commandText2)
        {
            int returnValue = 0;
            try
            {
                using (TransactionScope scope = new TransactionScope())
                {
                    using (SqlConnection connection1 = new SqlConnection(connectString1))
                    {
                        connection1.Open();

                        SqlCommand command1 = new SqlCommand(commandText1, connection1);
                        returnValue = command1.ExecuteNonQuery();
                    }
                    scope.Complete();
                }

            }
            catch (TransactionAbortedException ex)
            {
                Debug.WriteLine("TransactionAbortedException Message: {0}", ex.Message);
            }
            catch (ApplicationException ex)
            {
                Debug.WriteLine("ApplicationException Message: {0}", ex.Message);
            }

            return returnValue;
        }
    }
}
