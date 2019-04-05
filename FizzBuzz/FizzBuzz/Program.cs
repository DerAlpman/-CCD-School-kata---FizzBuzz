using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in FizzBuzzer.FizzBuzzRange(1, 100))
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

            foreach (var item in FizzBuzzer.FizzBuzzRange(1, 100, true))
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
