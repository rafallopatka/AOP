using System;
using System.Diagnostics;
using ArxOne.MrAdvice.Advice;

namespace CustomAdvices
{
    class LogErrorsAdviceAttribute : Attribute, IMethodAdvice
    {
        public void Advise(MethodAdviceContext context)
        {
            var originalColor = Console.ForegroundColor;

            Stopwatch sw = new Stopwatch();
            sw.Start();

            try
            {
                Console.WriteLine("Before");

                context.Proceed();

                Console.WriteLine("After");

                if (context.HasReturnValue)
                {
                    var generalResult = context.ReturnValue as GeneralResult;
                    if (generalResult != null && generalResult.IsSuccess == false)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Method: {context.TargetMethod.Name} failed: {generalResult.Message}, \n Params: [{String.Join(",", context.Parameters)}]");
                        Console.ForegroundColor = originalColor;
                    }
                }
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Method: {context.TargetMethod.Name} throws exception. \n Params: [{String.Join(",", context.Parameters)}] \n Exception: \n {e}");
                Console.ForegroundColor = originalColor;

                context.ReturnValue = new GeneralResult {IsSuccess = false, Message = "Exception occured"};
            }

            sw.Stop();

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine($"Method {context.TargetMethod.Name} execution time: {sw.Elapsed}");

            Console.ForegroundColor = originalColor;
        }
    }
}
