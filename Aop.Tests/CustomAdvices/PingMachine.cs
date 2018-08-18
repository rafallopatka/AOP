using System;

namespace CustomAdvices
{
    [LogErrorsAdvice]
    class PingMachine
    {
        public GeneralResult MakePing(int times)
        {
            var result = new GeneralResult();
            if (times < 0)
            {
                result.IsSuccess = false;
                result.Message = "times < 0";
                return result;
            }

            if (times == 0)
            {
                throw new ArgumentException($"Parameter {times} should be greater than 0");
            }

            for (int i = 0; i < times; i++)
            {
                var originalColor = Console.ForegroundColor;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("PING");
                Console.ForegroundColor = originalColor;
            }

            result.IsSuccess = true;
            return result;
        }

        public GeneralResult MakePing(int times, string message)
        {
            var result = new GeneralResult();
            if (times < 0)
            {
                result.IsSuccess = false;
                result.Message = "times < 0";
                return result;
            }

            if (times == 0)
            {
                result.IsSuccess = false;
                result.Message = "times == 0";
                return result;
            }

            for (int i = 0; i < times; i++)
            {
                var originalColor = Console.ForegroundColor;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(message);
                Console.ForegroundColor = originalColor;
            }

            result.IsSuccess = true;
            return result;
        }
    }

    class GeneralResult
    {
        public string Message { get; set; }
        public bool IsSuccess { get; set; }
    }

}
