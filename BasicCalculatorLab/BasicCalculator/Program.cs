using System;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** BASIC DEW POINT CALCULATOR ***");

            Console.WriteLine("Enter Current Temperature");

            // int.Parse will take a string data type and convert it to an int data type
            int cTemp = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Relative Humidity");
            int rh = int.Parse(Console.ReadLine());

            int dewPoint = cTemp - (100-rh)*9/25;

            Console.WriteLine("The Dew Point is " + dewPoint);

            Console.WriteLine("*** BASIC WIND CHILL CALCULATOR ***");

            Console.WriteLine("Enter the Wind Speed");

            int windSpeed = int.Parse(Console.ReadLine());

            double windChill = 35.74 + .6215 * cTemp - 35.75 * Math.Pow(windSpeed, 0.16) + 0.4275 * cTemp * Math.Pow(windSpeed, 0.16);

            Console.WriteLine("The Wind Chill is " + windChill);
        }
    }
}
