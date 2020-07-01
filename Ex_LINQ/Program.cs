using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // FASE 1 ------------------------------------------------------------------------
            // 1. Data Source
            int[] numArray = new int[15] { 2, 6, 8, 4, 5, 5, 9, 2, 1, 8, 7, 5, 9, 6, 4 };

            // 2. Query Creation
            var pairs = from n in numArray
                        where (n % 2) == 0
                        select n;

            // Query Execution
            foreach (int n in pairs)
            {
                Console.Write(n + " ");
            }
            Console.Write("\n");

            // FASE 2 --------------------------------------------------------------------------    
            var avgMark = numArray.Average();
            var maxMark = numArray.Max();
            var minMark = numArray.Min();
            Console.WriteLine("Average Mark: " + avgMark);
            Console.WriteLine("Maximum Mark: " + maxMark);
            Console.WriteLine("Minimum Mark: " + minMark);

            //FASE 3 ---------------------------------------------------------------------------
            var Major5 = from n in numArray
                         where n > 5
                         select n;

            var Minor5 = from n in numArray
                         where n < 5
                         select n;

            foreach (int n in Major5)
            {
                Console.Write(n + " ");
            }
            Console.Write("\n");

            foreach (int n in Minor5)
            {
                Console.Write(n + " ");
            }
            Console.Write("\n");

            //FASE 4 ---------------------------------------------------------------------------
            string[] nameArray = new string[7] { "David", "Sergio", "Maria", "Laura", "Oscar", "Julia", "Oriol" };
            
            var StartwithO = from s in nameArray
                             where s.StartsWith('O')
                             select s;
            
            foreach (string s in StartwithO)
            {
                Console.Write(s + " ");
            }
            Console.Write("\n");
            // -----------------------------------------------------
            var Morethan6 = from s in nameArray
                            where s.Count() > 6
                            select s;

            foreach (string s in Morethan6)
            {
                Console.Write(s + " ");
            }
            Console.Write("\n");
            // -----------------------------------------------------
            var Sorted = from s in nameArray
                         orderby s descending
                         select s;

            foreach (string s in Sorted)
            {
                Console.WriteLine(s);
            }
        }
    }
}
