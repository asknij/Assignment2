using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Conversion
    {
        private int temperature;
        public Conversion()
        {
            temperature = 1;
        }
        public Conversion(int a)
        {
            temperature = a;
        }



        public double ConvertCelciusToFahrenheit()
        {
            return ((temperature * (9.00 / 5.00)) + 32.00);
        }
        public double ConvertCelciusToKelvin()
        {
            return (temperature + 273.15);
        }
        public double ConvertKelvinToFahrenheit()
        {
            return (((temperature - 273.15) * (9.00 / 5.00)) + 32.00);
        }
        public double ConvertKelvinToCelsius()
        {
            return ((temperature - 273.15));
        }
        public double ConvertFahrenheitToKelvin()
        {
            return (((temperature - 32.00) * (5.00 / 9.00)) + 273.15);
        }
        public double ConvertFahrenheitToCelsius()
        {
            return ((temperature - 32.00) * (5.00 / 9.00));
        }




    }
}
