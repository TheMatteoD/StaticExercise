using System;

namespace StaticExerciseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(TempConverter.CelsiusToFahrenheit(0));
            Console.WriteLine(TempConverter.FahrenheitToCelsius(32));
        }
    }
}
