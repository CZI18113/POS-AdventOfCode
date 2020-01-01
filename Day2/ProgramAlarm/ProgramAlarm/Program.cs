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
                int[] data = line.Split(',').Select(x => int.Parse(x)).ToArray();
                compute(12, 2);


                int compute(int one, int two)
                {
                    data[1] = one;
                    data[2] = two;

                    int pointer = 0;
                    while (data[pointer] != 99)
                    {
                        if (data[pointer] == 1)
                        {
                            data[data[pointer + 3]] = data[data[pointer + 1]] + data[data[pointer + 2]];
                        }
                        else if (data[pointer] == 2)
                        {
                            data[data[pointer + 3]] = data[data[pointer + 1]] * data[data[pointer + 2]];
                        }
                        pointer += 4;
                    }
                    return data[result];
                }
                Console.WriteLine("result of part one: " + data[result]);


            }


        }
    }
}
