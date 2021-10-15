using System;

namespace staticKW
{
    class Program
    {
        class MyClass
        {
            //Non Static Members
            public string message = "Hello World";
            public string Name { get; set; }
            public void DisplayName()
            {
                Console.WriteLine("Name = {0}", Name);
            }

            // static members

            public static string greetings = "Good Morning";
            public static int Age { get; set; }
            public static void DisplayAge()
            {
                Console.WriteLine("Age = {0}", Age);
            }
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            MyClass classA = new MyClass();

            Console.WriteLine(classA.message);
            classA.Name = "Simon";
            classA.DisplayName();

            Console.WriteLine(MyClass.greetings);
            MyClass.Age = 21;
            MyClass.DisplayAge();

            Console.Read();
        }
    }
}
