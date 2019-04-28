using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorldWriter
{
    public class ConsoleWriter : MessageWriter
    {
        public override void Write(string message)
        {
            Console.WriteLine(message);
        }
    }
}
