class MessageSender
{
    public bool Send(Message message)
    {
        if (Validate(message))
            return false;

        Operation1();
        Operation2();
        Operation3();

        return true;
    }
}
