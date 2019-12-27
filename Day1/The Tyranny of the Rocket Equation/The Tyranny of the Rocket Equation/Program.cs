using System;

namespace The_Tyranny_of_the_Rocket_Equation
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] imput = System.IO.File.ReadAllLines("C:/users/micha/Desktop/AdventOfCode_POS/POS-AdventOfCode/Day1/PuzzleImput.txt");
            Console.WriteLine("Total Fuel: " + CalcFuel(imput));
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
    }
}
