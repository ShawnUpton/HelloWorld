using System;

namespace HelloWorld.Shared
{
    public static class PersonFactory
    {
        public static string Greet()
        {
            var greeter = new Greeter();
            return greeter.Greeting;

        }            
    } 
}
