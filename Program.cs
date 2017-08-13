using System;

namespace task1_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Temperature in Celsius(°C)");
             var inputC = int.Parse(Console.ReadLine());
              // Convert Celsius to Fahrenheit
              double fahrenheit = (inputC * 9 / 5) + 32;
            Console.WriteLine("0Temperature in Fahrenheit is(°F)");
            var inputF = Console.ReadLine();
            // Convert Fahrenheit to Celsius
            double celsius = (fahrenheit - 32) * 5 / 9;

                     




        }
    }
}
