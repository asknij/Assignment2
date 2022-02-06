using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            int temperature = 1, flag = 0, choice;
            Conversion temp;
            bool end = true;
            do
            {
                if (flag == 0)
                {
                    Console.WriteLine("Enter the value to be converted  :");
                }
                if (!int.TryParse(Console.ReadLine(), out temperature))
                {
                    Console.WriteLine("\nPlease enter an integer value");
                    flag = 1;

                }
                else if (temperature <= 0)
                {
                    Console.WriteLine("\nPlease enter a value greater than 0");
                    flag = 1;
                }
                else
                {
                    flag = 0;
                }
            } while (flag == 1);

            temp = new Conversion(temperature);
            do
            {
                do
                {
                    Console.WriteLine("\nAvailable options :\n\t1.Convert Celsius to Fahrenheit  \n\t2.Convert Celsius to Kelvin\n\t3.Convert Fahrenheit to Celsius\n\t4.Convert Fahrenheit to Kelvin\n\t5.Convert Kelvin to Celsius\n\t6.Convert Kelvin to Fahrenheit\n\t7.Exit");
                    Console.WriteLine("\nEnter your choice");
                } while (!int.TryParse(Console.ReadLine(), out choice) || (choice > 7 || choice < 1));
                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine("\nFahrenheit  :" + temp.ConvertCelciusToFahrenheit());
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("\nKelvin  :" + temp.ConvertCelciusToKelvin());
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("\nCelsius  :" + temp.ConvertFahrenheitToCelsius());
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("\nKelvin  :" + temp.ConvertFahrenheitToKelvin());
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("\nCelsius  :" + temp.ConvertKelvinToCelsius());
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("\nFahrenheit  :" + temp.ConvertKelvinToFahrenheit());
                            break;
                        }
                    case 7:
                        {
                            end = false;
                            break;

                        }

                }
            } while (end);

        }

    }
}
