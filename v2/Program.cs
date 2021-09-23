using System;

namespace PizzaCalc2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Pizza Calculator by Wolfdud3");
            Console.WriteLine("-----");

            Console.Write("How many Pizzas would you like to calculate? ");
            int amountPizza = Convert.ToInt32(Console.ReadLine());

            string[] pizzaNameArray = new string[amountPizza];
            double[] pizzaArray = new double[amountPizza];
            
            for(int i = 0; i < amountPizza; i++)
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
                Console.WriteLine("price per qcm is " + ppqRounded);

                //write
                pizzaNameArray.SetValue(pizzaName, i);
                pizzaArray.SetValue(ppqRounded, i);
            }

            //give out everything
            int arrayLength = pizzaArray.Length;
            for(int j = 0; j < arrayLength; j++)
            {
                Console.Write(pizzaNameArray[j] + " - ");
                Console.WriteLine(pizzaArray[j]);
            }
            Console.WriteLine("\nThank you for using the Pizza Calculator.");
            Console.WriteLine("Press Enter to exit.");

            //exit key
            ConsoleKeyInfo cki;
            cki = Console.ReadKey();
            do
            {

            }
            while (cki.Key != ConsoleKey.Enter);
        }
    }
}
