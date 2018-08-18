using System;
using System.Transactions;
using ArxOne.MrAdvice.Advice;

namespace CustomAdvices
{
    class TransactionalAdviceAttribute : Attribute, IMethodAdvice
    {
        public void Advise(MethodAdviceContext context)
        {
            using (var transactionScope = new TransactionScope())
            {
                if (context.Parameters[0] == null)
                    context.Parameters[0] = new SqlConntection();
                
                context.Proceed();

                if (context.HasReturnValue)
                {
                    bool success = (bool) context.ReturnValue;
                    if (success)
                    {
                        transactionScope.Complete();
                    }
                }
                else
                {
                    transactionScope.Complete();
                }
            }
        }

    }

    static class AdviceExtensions
    {
        public static Type GetDeclaredType<T>(this T obj)
        {
            return typeof(T);
        }
    }
}
