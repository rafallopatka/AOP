namespace Aop.Tests
{
    class Message
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string From { get; set; }
        public string To { get; set; }
        public string Body { get; set; }
    }

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

        private void Operation1()
        {
            throw new System.NotImplementedException();
        }

        private void Operation2()
        {
            throw new System.NotImplementedException();
        }

        private void Operation3()
        {
            throw new System.NotImplementedException();
        }

        private bool Validate(Message message)
        {
            throw new System.NotImplementedException();
        }
    }
}
