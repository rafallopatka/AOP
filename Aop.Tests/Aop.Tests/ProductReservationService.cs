
using System;

namespace Aop.Tests
{
    class ProductReservationService
    {
        public bool Reserve(Product product, User user)
        {
            try
            {
                bool result = SubOperation1();
                if (result == false)
                {
                    Logger.Error($"Operation: {nameof(SubOperation1)} failed. Parameters: {SerializeParameters(product, user)}");
                    return false;
                }

                result = SubOperation2();
                if (result == false)
                {
                    Logger.Error($"Operation: {nameof(SubOperation2)} failed. Parameters: {SerializeParameters(product, user)}");
                    return false;
                }

                result = SubOperation3();
                if (result == false)
                {
                    Logger.Error($"Operation: {nameof(SubOperation3)} failed. Parameters: {SerializeParameters(product, user)}");
                    return false;
                }

                result = SubOperation4();
                if (result == false)
                {
                    Logger.Error($"Operation: {nameof(SubOperation4)} failed. Parameters: {SerializeParameters(product, user)}");
                    return false;
                }

                result = SubOperation5();
                if (result == false)
                {
                    Logger.Error($"Operation: {nameof(SubOperation5)} failed. Parameters: {SerializeParameters(product, user)}");
                    return false;
                }

                result = SubOperation6();
                if (result == false)
                {
                    Logger.Error($"Operation: {nameof(SubOperation6)} failed. Parameters: {SerializeParameters(product, user)}");
                    return false;
                }

                return true;
            }
            catch (Exception e)
            {
                Logger.Error($"Method: {nameof(ProductReservationService)}.{nameof(Reserve)} failed. Parameters: {SerializeParameters(product, user)} \n Exception: {e}");
                
                return false;
            }
        }

        private string SerializeParameters(Product product, User user)
        {
            throw new NotImplementedException();
        }

        private bool SubOperation6()
        {
            return true;
        }

        private bool SubOperation5()
        {
            return true;
        }

        private bool SubOperation4()
        {
            return true;
        }

        private bool SubOperation3()
        {
            return true;
        }

        private bool SubOperation2()
        {
            return true;
        }

        private bool SubOperation1()
        {
            throw new System.NotImplementedException();
        }
    }

    internal class Logger
    {
        public static void Error(string s)
        {
            throw new NotImplementedException();
        }
    }

    internal class ServiceResult
    {
        public bool Success { get; set; }
        public bool Message { get; set; }
    }

    internal class Product
    {
        public long Id { get; set; }
    }

    internal class User
    {
        public long Id { get; set; }
    }
}
