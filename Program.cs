using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaCalc3
{
    class Pizza
    {
        public string name { get; set; }
        public double ppq { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the");
            Console.WriteLine("█▀▄ █ ▀█▀ ▀█▀ ▄▀▄   ▄▀▀ ▄▀▄ █   ▄▀▀ █ █ █   ▄▀▄ ▀█▀ ▄▀▄ █▀▄");
            Console.WriteLine("█▀  █ █▄▄ █▄▄ █▀█   ▀▄▄ █▀█ █▄▄ ▀▄▄ ▀▄█ █▄▄ █▀█  █  ▀▄▀ █▀▄ Less thinking, more Pizza");
            Console.WriteLine("by Wolfdud3");
            Console.WriteLine("----------");
            Console.WriteLine("Use this calculator to calculate the price of pizza per square centimeter.");
            Console.WriteLine("Simply put in what is asked for and see where you can save money.");

            List<Pizza> listOfPizza = new List<Pizza>();

            ConsoleKeyInfo cki;
            ConsoleKeyInfo cki2;
            do
            {
                //name
                Console.Write("\nGive this Pizza a name: ");
                string pizzaName = Console.ReadLine();

                //size
                Console.Write("Please enter the diameter of the Pizza in cm: ");
                string diameterString = Console.ReadLine();
                double radius = Convert.ToDouble(diameterString) / 2;
                double pizzaSize = Math.PI * radius * radius;

                //price
                Console.Write("Please enter the price of the Pizza: ");
                string pizzaPriceString = Console.ReadLine();
                double pizzaPrice = Convert.ToDouble(pizzaPriceString);

                //calc
                double ppq = pizzaPrice / pizzaSize;
                double ppqRounded = Math.Round(ppq, 2);

                listOfPizza.Add(new Pizza() { name = pizzaName, ppq = ppqRounded });

                Console.WriteLine("----------");
                Console.WriteLine("Press esc to show result.");
                Console.WriteLine("Press any button to continue");
                cki = Console.ReadKey();
            }
            while (cki.Key != ConsoleKey.Escape);

            Console.WriteLine("\naThe results are:");   //I know, I know...not a nice solution, but it works. lol.
            for (int i = 0; i < listOfPizza.Count; i++)
            {
                Console.WriteLine(listOfPizza[i].name + " - " + listOfPizza[i].ppq);
            }

            Console.WriteLine("\nThank you for using the Pizza Calculator");
            Console.WriteLine("Press ENTER to exit.");
            //exit code
            cki2 = Console.ReadKey();
            do
            {

            }
            while (cki2.Key != ConsoleKey.Enter);
        }
    }
}
