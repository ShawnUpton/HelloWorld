using HelloWorld.Shared;
using System;
using System.Dynamic;

namespace HelloWorld.Business
{
    public class HelloWorldLogic
    {
        public string ConnectionString { get; set; }

        public HelloWorldLogic()
        {

        }

        public HelloWorldLogic(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public string GetGreeting()
        {
            return PersonFactory.Greet();

        }
    }
}
