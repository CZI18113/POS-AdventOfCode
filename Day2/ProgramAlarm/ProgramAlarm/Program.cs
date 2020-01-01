using System;
using System.IO;
using System.Linq;

namespace ProgramAlarm
{
    public class Program
    {
        // public string path = "C:/users/micha/Desktop/AdventOfCode_POS/POS-AdventOfCode/Day2/Day2Input.txt";
        public static void Main(string[] args)
        {
            int result = 0;
            string iPath = Path.Combine(Environment.CurrentDirectory, "\\users/micha/Desktop/AdventOfCode_POS/POS-AdventOfCode/Day2/Day2Input.txt");

            if (!File.Exists(iPath))
            {
                Console.WriteLine($"Error! File with path {iPath} not found! Maybe check directory or path correctness");
                return;
            }

            using (StreamReader sr = new StreamReader(iPath))
            {

                // All input is on the first line
                string line = sr.ReadLine();
                int[] origin = line.Split(',').Select(x => int.Parse(x)).ToArray();
                int[] adapted = new int[origin.Length];

                Console.WriteLine("result of part one: " + compute(12, 2));

                int compute(int one, int two)
                {
                    for(int i = 0; i < origin.Length; i ++) { adapted[i] = origin[i]; }

                    adapted[1] = one;
                    adapted[2] = two;

                    int pointer = 0;
                    while (adapted[pointer] != 99)
                    {
                        if (adapted[pointer] == 1)
                        {
                            adapted[adapted[pointer + 3]] = adapted[adapted[pointer + 1]] + adapted[adapted[pointer + 2]];
                        }
                        else if (adapted[pointer] == 2)
                        {
                            adapted[adapted[pointer + 3]] = adapted[adapted[pointer + 1]] * adapted[adapted[pointer + 2]];
                        }
                        pointer += 4;
                    }
                    return adapted[result];
                }


                // Here comes part two 

                for (int noun = 0; noun <= 99; noun++)
                {
                    for (int verb = 0; verb <= 99; verb++)
                    {
                        if (compute(noun, verb) == 19690720)
                        {
                            Console.WriteLine("result of part two: " + (100 * noun + verb));
                            return;
                        }
                    }
                }

            }


        }
    }
}
