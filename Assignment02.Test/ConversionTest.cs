﻿using Assignment2;
using NUnit.Framework;

namespace Assignment02.Test
{
    public class ConversionTest
    {
        private const string Expected = "Hello World!";
        Conversion conversion;
        [SetUp]
        public void Setup()
        {
            conversion = new Conversion();
        }
        [Test]
        public void ConvertCelciusToFahrenheitTestPositiveInteger()
        {
            var userInput = 12;
            var expected = 53.6;
            conversion = new Conversion(userInput);
            var actual = conversion.ConvertCelciusToFahrenheit();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void ConvertCelciusToFahrenheitTestNegativeInteger()
        {
            var userInput = -10;
            var expected = 14;
            conversion = new Conversion(userInput);
            var actual = conversion.ConvertCelciusToFahrenheit();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void ConvertCelciusToFahrenheitTestZeroInput()
        {
            var userInput = 0;
            var expected = 32;
            conversion = new Conversion(userInput);
            var actual = conversion.ConvertCelciusToFahrenheit();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void ConvertCelciusToKelvinTestPositiveInteger()
        {
            var userInput = 12;
            var expected = 285.15;
            conversion = new Conversion(userInput);
            var actual = conversion.ConvertCelciusToKelvin();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void ConvertCelciusToKelvinTestNegativeInteger()
        {
            var userInput = -10;
            var expected = 263.15;
            conversion = new Conversion(userInput);
            var actual = conversion.ConvertCelciusToKelvin();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void ConvertCelciusToKelvinTestZeroInput()
        {
            var userInput = 0;
            var expected = 273.15;
            conversion = new Conversion(userInput);
            var actual = conversion.ConvertCelciusToKelvin();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void ConvertFahrenheitToCelsiusTestPositiveInteger()
        {
            var userInput = 12;
            var expected = -11.11;
            conversion = new Conversion(userInput);
            var actual = conversion.ConvertFahrenheitToCelsius();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void ConvertFahrenheitToCelsiusTestNegativeInteger()
        {
            var userInput = -10;
            var expected = -23.33;
            conversion = new Conversion(userInput);
            var actual = conversion.ConvertFahrenheitToCelsius();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void ConvertFahrenheitToCelsiusTestZeroInput()
        {
            var userInput = 0;
            var expected = -17.78;
            conversion = new Conversion(userInput);
            var actual = conversion.ConvertFahrenheitToCelsius();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void ConvertFahrenheitToKelvinTestPositiveInteger()
        {
            var userInput = 12;
            var expected = 262.04;
            conversion = new Conversion(userInput);
            var actual = conversion.ConvertFahrenheitToKelvin();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void ConvertFahrenheitToKelvinTestNegativeInteger()
        {
            var userInput = -10;
            var expected = 249.82;
            conversion = new Conversion(userInput);
            var actual = conversion.ConvertFahrenheitToKelvin();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void ConvertFahrenheitToKelvinTestZeroInput()
        {
            var userInput = 0;
            var expected = 255.37;
            conversion = new Conversion(userInput);
            var actual = conversion.ConvertFahrenheitToKelvin();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void ConvertKelvinToCelsiusTestPositiveInteger()
        {
            var userInput = 12;
            var expected = -261.15;
            conversion = new Conversion(userInput);
            var actual = conversion.ConvertKelvinToCelsius();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void ConvertKelvinToCelsiusTestNegativeInteger()
        {
            var userInput = -10;
            var expected = -283.15;
            conversion = new Conversion(userInput);
            var actual = conversion.ConvertKelvinToCelsius();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void ConvertKelvinToCelsiusTestZeroInput()
        {
            var userInput = 0;
            var expected = -273.15;
            conversion = new Conversion(userInput);
            var actual = conversion.ConvertKelvinToCelsius();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void ConvertKelvinToFahrenheitTestPositiveInteger()
        {
            var userInput = 12;
            var expected = -438.07;
            conversion = new Conversion(userInput);
            var actual = conversion.ConvertKelvinToFahrenheit();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void ConvertKelvinToFahrenheitTestNegativeInteger()
        {
            var userInput = -10;
            var expected = -477.67;
            conversion = new Conversion(userInput);
            var actual = conversion.ConvertKelvinToFahrenheit();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void ConvertKelvinToFahrenheitTestZeroInput()
        {
            var userInput = 0;
            var expected = -459.67;
            conversion = new Conversion(userInput);
            var actual = conversion.ConvertKelvinToFahrenheit();
            Assert.AreEqual(expected, actual);
        }

    }
}
