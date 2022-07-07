using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WORKSHOP_1
{
    public class TemperatureConversion
    {
        public static void CelciusToFarhenite()
        {
            Console.Write("Enter Temperature In Celcius : ");
            double celcius = Convert.ToDouble(Console.ReadLine());

            double farhenite = (celcius * 9 / 5) +32;
            Console.WriteLine("The Temperature In Farhenite : {0} ", farhenite);
        }

        public static void FarheniteToCelcius()
        {
            Console.Write("Enter Temperature In Farhenite : ");
            double farhenite = Convert.ToDouble(Console.ReadLine());

            double celcius = (farhenite - 32) * 5 / 9;
            Console.WriteLine("The Temperature In Celcius : {0} ", celcius);
        }

    }
}
