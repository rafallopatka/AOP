public bool Reserve(Product product, User user)
{
    try
    {
        bool result = SubOperation1();
        if (result == false)
            return false;

        result = SubOperation2();
        if (result == false)
            return false;

        result = SubOperation3();
        if (result == false)
            return false;

        result = SubOperation4();
        if (result == false)
            return false;

        result = SubOperation5();
        if (result == false)
            return false;

        result = SubOperation6();
        if (result == false)
            return false;

        return true;
    }
    catch (Exception e)
    {
        return false;
    }
}
