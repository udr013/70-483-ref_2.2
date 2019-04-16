using System;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Miles miles = new Miles(100);

            Kilometers k = miles; //implicit convert to kilometers
            Console.WriteLine("Kilometers: {0}", k.Distance);

            int intMiles = (int)miles; // explicit convert miles to int

            Console.WriteLine("Int miles: {0}", intMiles);


            //an other conversion with System.Convert
            //System.FormatException: 'Input string was not in a correct format
            int number = Convert.ToInt32("22");
            Console.WriteLine(number);
            Console.ReadKey();

        }
    }
}

