using System;

namespace PizzaCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Pizza Calculator by Wolfdud3");
            Console.WriteLine("-----");

            //calculate pizza size
            Console.Write("Please enter the diameter of the Pizza in cm: ");
            string diameterString = Console.ReadLine();
            double radius = Convert.ToDouble(diameterString)/2;
            double pizzaSize = Math.PI * radius * radius;

            //get price
            Console.Write("Please enter the price of the Pizza: ");
            string pizzaPriceString = Console.ReadLine();
            double pizzaPrice = Convert.ToDouble(pizzaPriceString);

            //calculate ppq (price per qcm)
            double ppq = pizzaPrice / pizzaSize;
            double ppqRounded = Math.Round(ppq, 2);
            Console.WriteLine("price per qcm is " + ppqRounded + "\n");

            Console.WriteLine("Thank you for using the Pizza Calculator");
            Console.WriteLine("Press Enter to Exit.");

            //exit
            ConsoleKeyInfo cki;
            cki = Console.ReadKey();
            do
            {

            }
            while (cki.Key != ConsoleKey.Enter);
        }
    }
}
