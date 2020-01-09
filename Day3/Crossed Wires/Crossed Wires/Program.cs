using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;

namespace Crossed_Wires
{
    public class Program
    {
        static void Main(string[] args)
        {
            // int result = 0;
            string iPath = Path.Combine(Environment.CurrentDirectory, "\\users/micha/Desktop/AdventOfCode_POS/POS-AdventOfCode/Day3/Day3Input.txt");

            if (!File.Exists(iPath))
            {
                Console.WriteLine($"Error! File with path {iPath} not found! Maybe check directory or path correctness");
                return;
            }
            
            using (StreamReader sr = new StreamReader(iPath))
            {
                
                /*
                 * Line coordinates separated by ','
                 * Lines separated by '\n'
                 */
                string line = sr.ReadLine();

                string[] line1 = line.Split(',');
                line = sr.ReadLine();
                string[] line2 = line.Split(',');

                /* string splitter = ",";
                switch (splitter)
                {
                    case ",":
                        line1 = line.Split(splitter);
                        break;
                    case "\r":
                        line2 = line.Split(',');
                        break;
                    default:
                        Console.WriteLine("Error with line-splitting!");
                        break;

                } */

                    
                var Line1 = DrawLine(line1);
                    var Line2 = DrawLine(line2);

                    List<Point> crosspoints = Line1.Intersect(Line2).ToList();

                    List<int> distances = new List<int>();
                    foreach(Point p in crosspoints)
                    {
                        distances.Add(CalcManhatten(0, p.X, 0, p.Y));
                    }
                Console.WriteLine("Result of Day 3 Part 1: " + distances.Min());

                int distLine1 = Line1.IndexOf(crosspoints.First()) + 1;
                int distLine2 = Line2.IndexOf(crosspoints.First()) + 1;
                Console.WriteLine("Result of Day 3 Part 2: " + (distLine1 + distLine2));
                                   
            }

            /*
             * "draws" the line by marking the x and y coordinate of each step as a point in list "line"
             */

            List<Point> DrawLine(string[] or)
            {
                Point last = new Point(0, 0);
                List<Point> line = new List<Point>();

                foreach (string dir in or)
                {
                    DrawDir(last, dir, line);
                    last = line.Last();
                }
                //line.RemoveAt(0);
                return line;
            }

            void DrawDir(Point p, string or, List<Point> line)
            {
                string dir = or.Substring(0, 1);
                int dis = int.Parse(or.Substring(1, or.Length - 1));

                switch (dir)
                {
                    case "R":
                        for (int i = 1; i <= dis; i++)
                        {
                            line.Add(new Point(p.X + i, p.Y));
                        }
                        break;
                    case "U":
                        for (int i = 1; i <= dis; i++)
                        {
                            line.Add(new Point(p.X, p.Y + i));
                        }
                        break;
                    case "L":
                        for (int i = 1; i <= dis; i++)
                        {
                            line.Add(new Point(p.X - i, p.Y));
                        }
                        break;
                    case "D":
                        for (int i = 1; i <= dis; i++)
                        {
                            line.Add(new Point(p.X, p.Y - i));
                        }
                        break;
                    default:
                        Console.WriteLine("Error in Method DrawDir, wrong direction operator or wrong input schema!");
                        break;
                }
            }

            int CalcManhatten(int x, int x2, int y, int y2)
            {
                int erg = Math.Abs(x - x2) + Math.Abs(y - y2);
                return erg;
            }

        }
    }
}
