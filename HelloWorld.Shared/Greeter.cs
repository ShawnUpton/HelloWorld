using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Shared
{
    public class Greeter : IPerson
    {
        public string Greeting { get; private set; }

        public Greeter()
        {
            Greeting = "Hello World";
        }

    }
}
