using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public class TempConverter
    {
        public static double FahrenheitToCelsius (double value) {
            double temp = 32 + (value * 1.8);
            return temp;
        }
        public static double CelsiusToFahrenheit(double value)
        {
            //double temp = (value - 32) * (5/9);
            double temp = (value - 32) / 1.8;
            return temp;
        }
    }
}
