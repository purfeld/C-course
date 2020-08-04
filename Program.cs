using System;

namespace Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = args[0];
            //Console.WriteLine("Hello World! " + name);

            foreach (var item in args)
            {
                Console.WriteLine("Witaj, " + item);
            }
        }
    }
}
