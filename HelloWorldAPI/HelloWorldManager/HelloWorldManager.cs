using System;

namespace HelloWorldManager
{
    public class HelloWorldManager : IHelloWorldManager
    {
        public HelloWorldManager()
        {

        }

        public string GetHelloWorldMessage()
        {
            //Can be extended to add additional logic, return from database (repository layer) etc
            return "Hello World";
        }
    }
}
