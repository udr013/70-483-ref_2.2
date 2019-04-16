using System;
using System.Dynamic;

namespace BadDynamicCode
{
    class MessageDisplay
    {
        public void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
           
            dynamic d = 99;
            d = d + 1;
            Console.WriteLine(d);

            d = "Hello";
            d = d + " Rob";
            Console.WriteLine(d);

            //ExpandoObject allows to dynamicly add properties to an object!
            dynamic person = new ExpandoObject();
            person.Name = "udr013";
            
            person.Hobby = "Music";

            Console.WriteLine("Name: {0}, Hobby: {1}", person.Name, person.Hobby);

            MessageDisplay m = new MessageDisplay();
            m.DisplayMessage("Hello world");
            //the dynamic keywoird can be used to skip static type checking, though seems like badcoding.... and can cause errors!
            d = new MessageDisplay();
            d.DisplayMessage("HelloWorld");
            //this is BS
            d.Banana("HelloWorld");
            Console.WriteLine("Hello World!");
        }
    }
}
