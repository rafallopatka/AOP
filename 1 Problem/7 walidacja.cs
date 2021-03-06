public bool Reserve(Product product, User user)
{
    try
    {
        if (ValidateParameter(product) == false)
        {
            Logger.Error($"Method: {nameof(Reserve)} failed - invalid parameter {nameof(product)}. Parameters: {SerializeParameters(product, user)}");
            return false;
        }

        if (ValidateParameter(user) == false)
        {
            Logger.Error($"Method: {nameof(Reserve)} failed - invalid parameter {nameof(user)}. Parameters: {SerializeParameters(product, user)}");
            return false;
        }

        if (HasReservationPerrmissions(user) == false)
        {
            Logger.Error($"Method: {nameof(Reserve)} failed insufficient permissions. Parameters: {SerializeParameters(product, user)}");
            return false;
        }

        using(var transactionScope = new TransactionScope())
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

            transactionScope.Complete();
            return true;
        }
    }
    catch (Exception e)
    {
        Logger.Error($"Method: {nameof(ProductReservationService)}.{nameof(Reserve)} failed. Parameters: {SerializeParameters(product, user)} \n Exception: {e}");

        return false;
    }
}
