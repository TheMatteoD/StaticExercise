using System;
using System.Collections.Generic;
using System.Text;

namespace StaticExerciseProject
{
    internal class TempConverter
    {
        public static double FahrenheitToCelsius(double f)
        {
            return (f-32)*(5/9);
        }
        public static double CelsiusToFahrenheit(double c)
        {
            return (c * (9/5)) + 32;
        }
    }
}
