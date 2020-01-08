using System;

namespace The_Tyranny_of_the_Rocket_Equation
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] imput = System.IO.File.ReadAllLines("C:/users/micha/Desktop/AdventOfCode_POS/POS-AdventOfCode/Day1/PuzzleImput.txt");
            Console.WriteLine("Total Fuel: " + CalcFuel(imput));
            Console.WriteLine("Total Fuel Part 2: " + CalcFuelCorrect(imput));
            Console.ReadLine();
        }

        static int CalcFuel(string[] put)
        {
            int erg = 0;
            int tempFuel = 0;
            foreach (string s in put)
            {
                int.TryParse(s, out tempFuel);
                int temp = (tempFuel / 3);
                erg += temp - 2;
            }
            return erg;
        }

        static int CalcFuelCorrect(string[] put)
        {
            int erg = 0;
            int tempFuel = 0;
            // int temp = 5;
            // int count = -1;
            foreach (string s in put)
            {
                int.TryParse(s, out tempFuel);
                while ((tempFuel / 3) - 2 > 0)
                {
                    tempFuel = (tempFuel / 3) - 2;
                    erg += tempFuel;
                }
            }
            return erg;
        }
    }
}
