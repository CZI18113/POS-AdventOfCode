using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Secure_Container
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Puzzle Input: 146810-612564
             */

            hack(146810, 612564);

            int hack(int min, int max)
            {
                int temp = min;
                List<int> numbers = new List<int>();
                // List<int> found = new List<int>();
                ArrayList found = new ArrayList();
                for(int i = min; i < max; i ++)
                {
                    if (temp.ToString().Length == 6)
                    {
                        while (temp != 0)
                        {
                            found.Add(temp % 10);
                            temp = temp / 10;
                        }

                        if (found.Count != 6)
                        {
                            return 0;
                        }

                        for (int j = 0; j <= 6; j ++)
                        {
                            if (found[j]  found[j + 1])
                            {
                                return 0;
                            }
                            else
                            {
                                int countDouble = found.GroupBy(x => x).Select(x => x.Count());
                                if(found[])
                            }
                        }
                    }
                }
                
                return 0;
            }

            /* void StringHack(int min, int max)
            {
                int temp = min;
                if (temp.ToString().Length == 6)
                {

                }
                Console.WriteLine(temp.);
            } */

        }
    }
}
