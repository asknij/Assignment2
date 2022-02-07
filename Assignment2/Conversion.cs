using System;

namespace Assignment2
{
    public class Conversion
    {
        private int temperature;
        //Default Constructor
        public Conversion()
        {
            temperature = 1;
        }
        //Parameterized Constructor
        public Conversion(int a)
        {
            temperature = a;
        }

        /// <summary>
        /// Converts Celcius to Fahrenheit
        /// </summary>
        /// <returns></returns>
        public double ConvertCelciusToFahrenheit()
        {
            return Math.Round(((temperature * (9.00 / 5.00)) + 32.00), 2);
        }

        /// <summary>
        /// Converts Celcius to Kelvin
        /// </summary> 
        /// <returns></returns>
        public double ConvertCelciusToKelvin()
        {
            return Math.Round(((temperature + 273.15)), 2);
        }

        /// <summary>
        /// Converts Kelvin to Fahrenheit
        /// </summary> 
        /// <returns></returns>
        public double ConvertKelvinToFahrenheit()
        {
            return Math.Round(((((temperature - 273.15) * (9.00 / 5.00)) + 32.00)), 2);
        }

        /// <summary>
        /// Converts Kelvin to Celcius
        /// </summary> 
        /// <returns></returns>
        public double ConvertKelvinToCelsius()
        {
            return Math.Round((((temperature - 273.15))), 2);
        }

        /// <summary>
        /// Converts Fahrenheit to Kelvin
        /// </summary> 
        /// <returns></returns>
        public double ConvertFahrenheitToKelvin()
        {
            return Math.Round(((((temperature - 32.00) * (5.00 / 9.00)) + 273.15)), 2);
        }

        /// <summary>
        /// Converts Fahrenheit to Celsius
        /// </summary> 
        /// <returns></returns>
        public double ConvertFahrenheitToCelsius()
        {
            return Math.Round((((temperature - 32.00) * (5.00 / 9.00))),2);
        }
    }
}
