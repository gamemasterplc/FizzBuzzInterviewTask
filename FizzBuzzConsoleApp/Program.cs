namespace FizzBuzzConsoleApp
{
    using FizzBuzzLib;
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            var fizzBuzzer = new FizzBuzz();
            IEnumerable<string> result = fizzBuzzer.FizzBuzzValuesForRange(1, 100);
            foreach(string data in result)
            {
                Console.WriteLine(data);
            }
            Console.ReadKey();
        }
    }
}
