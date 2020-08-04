using System;
using System.Dynamic;

namespace Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            ValueTypes();

            for (; ;)
            {
                Greeting();
                Calculation();
                Settings();

                //foreach (var item in args)
                //{
                //    Console.WriteLine("Witaj, " + item);
                //}
            }
        }

        private static void ValueTypes()
        {
            int maxInt = int.MaxValue;
            int minInt = int.MinValue;
            long maxLong = long.MaxValue;
            long minLong = long.MinValue;
            Console.WriteLine("Max INT = " + maxInt);
            Console.WriteLine("Min INT = " + minInt);
            Console.WriteLine("Max LONG = " + maxLong);
            Console.WriteLine("Min LONG = " + minLong);
        }

        /// <summary>
        /// Ustawienia
        /// </summary>
        private static void Settings()
        {
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
        }
        /// <summary>
        /// Komunikat zależny od wieku
        /// </summary>
        private static void Calculation()
        {
            Console.WriteLine("Wpisz ile masz lat: ");
            int age;
            bool result = int.TryParse(Console.ReadLine(), out age);

            if (age >= 18)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Brawo. Jesteś pełnoletni");
            }
            else if (result == false)
            {
                Console.WriteLine("Zły wiek");
            }
            else
            {
                Console.WriteLine("Puedes beber la leche");
            }
        }
        /// <summary>
        /// Wypisujemy powitanie użytkownika
        /// </summary>
        private static void Greeting()
        {
            Console.Write("Podaj imie: ");
            string name = Console.ReadLine();
            Console.WriteLine("Witaj " + name);
        }
    }
}
