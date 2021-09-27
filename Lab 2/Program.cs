using System;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            Console.WriteLine("Does your lamp work?");
            string lampBroken = Console.ReadLine();
            lampBroken = lampBroken.ToLower();
            if (lampBroken == "yes")
            {
                Console.WriteLine("Is the lamp plugged in?");
                string plugLamp = Console.ReadLine();
                plugLamp = plugLamp.ToLower();
                if (plugLamp == "no")
                {
                    Console.WriteLine("Plug in your lamp.");
                } else if (plugLamp == "yes")
                {
                    Console.WriteLine("Is the bulb burned out?");
                    string bulbBurned = Console.ReadLine();
                    bulbBurned = bulbBurned.ToLower();
                    if (bulbBurned == "yes")
                    {
                        Console.WriteLine("Replace the bulb.");
                    } else if (bulbBurned == "no")
                    {
                        Console.WriteLine("Repair the lamp.");
                    }
                }
            } else
            {
                Console.WriteLine("That's not a valid input. Please answer yes or no.");
            }

        }
    }
}
