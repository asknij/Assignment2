using Assignment2;
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
        public void ConvertCelciusToFahrenheitTestMethod1()
        {
            conversion = new Conversion(12);
            var result = conversion.ConvertCelciusToFahrenheit();
            Assert.AreEqual(53.6, result);
        }
        [Test]
        public void ConvertCelciusToFahrenheitTestMethod2()
        {
            conversion = new Conversion(-20);
            var result = conversion.ConvertCelciusToFahrenheit();
            Assert.AreEqual(4, result);
        }
        [Test]
        public void ConvertCelciusToFahrenheitTestMethod3()
        {
            conversion = new Conversion(0);
            var result = conversion.ConvertCelciusToFahrenheit();
            Assert.AreEqual(32, result);
        }
        [Test]
        public void ConvertCelciusToKelvinTestMethod1()
        {
            conversion = new Conversion(10);
            var result = conversion.ConvertCelciusToKelvin();
            Assert.AreEqual(283.15, result);
        }
        [Test]
        public void ConvertCelciusToKelvinTestMethod2()
        {
            conversion = new Conversion(-10);
            var result = conversion.ConvertCelciusToKelvin();
            Assert.AreEqual(263.15, result);
        }
        [Test]
        public void ConvertCelciusToKelvinTestMethod3()
        {
            conversion = new Conversion(0);
            var result = conversion.ConvertCelciusToKelvin();
            Assert.AreEqual(273.15, result);
        }
        [Test]
        public void ConvertFahrenheitToCelsiusTestMethod1()
        {
            conversion = new Conversion(12);
            var result = conversion.ConvertFahrenheitToCelsius();
            Assert.AreEqual(53.6, result);
        }
        [Test]
        public void ConvertFahrenheitToCelsiusTestMethod2()
        {
            conversion = new Conversion(-20);
            var result = conversion.ConvertFahrenheitToCelsius();
            Assert.AreEqual(4, result);
        }
        [Test]
        public void ConvertFahrenheitToCelsiusTestMethod3()
        {
            conversion = new Conversion(0);
            var result = conversion.ConvertFahrenheitToCelsius();
            Assert.AreEqual(32, result);
        }
    }
}
