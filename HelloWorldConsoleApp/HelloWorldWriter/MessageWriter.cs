using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorldWriter
{
    public abstract class MessageWriter : IMessageWriter
    {
        public static MessageWriter GetMessageWriter(string messageType)
        {
            switch (messageType)
            {
                case "Console":
                    return new ConsoleWriter();
                case "Default":
                    return new DatabaseWriter();
                default:
                    return new ConsoleWriter();
            }
        }

        public abstract void Write(string message);

    }
}
