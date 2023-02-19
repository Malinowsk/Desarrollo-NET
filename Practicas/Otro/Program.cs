using System;

namespace Otro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Platzi!");

            int height = 170;
            int age = 22;
            string name = "Abdel Mejia";
            string information = $"The requested info is:\nUser name: {name} \nUser age: {age} \nUser height: {height}";
            Console.WriteLine(information);
        }
    }
}

