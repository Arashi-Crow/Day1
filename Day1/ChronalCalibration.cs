using System;
using System.Collections.Generic;
using System.IO;

namespace Day1
{
    class ChronalCalibration
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("Chronal Calibration.txt");
            string[] changes = sr.ReadToEnd().Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            int Frecuency = PartA(changes);
            int repeated = PartB(changes);
            Console.WriteLine("PartA: " + Frecuency);            
            Console.WriteLine("PartB: " + repeated);
            Console.ReadKey();
        }

        public static int PartA(string[] changes)
        {
            int sum = 0;
            foreach (var frecuency in changes)
            {
                sum += Int32.Parse(frecuency);
            }
            return sum;
        }

        public static int PartB(string[] changes)
        {
            int sum = 0;
            HashSet<int> list = new HashSet<int>();
            while (true)
            {
                foreach (var frecuency in changes)
                {
                    sum += Int32.Parse(frecuency);
                    if (!list.Add(sum))
                    {
                        return sum;
                    }
                }
            }
        }
    }
}
