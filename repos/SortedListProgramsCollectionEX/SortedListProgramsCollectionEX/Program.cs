using System;
using System.Collections.Generic;

namespace SortedListProgramsCollectionEX
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------- SortedList ---------------------------------");
            SortedList<int, string> names = new SortedList<int, string>();
            names.Add(1, "Sonoo");
            names.Add(4, "Peter");
            names.Add(5, "James");
            names.Add(3, "Ratan");
            names.Add(2, "Irfan");
            foreach (KeyValuePair<int, string> kv in names)
            {
                Console.WriteLine(kv.Key + " " + kv.Value);
            }
            Console.WriteLine("Remove(5)");
            names.Remove(5);
            foreach (KeyValuePair<int, string> kv in names)
            {
                Console.WriteLine(kv.Key + " " + kv.Value);
            }
            Console.WriteLine("------------------------------------------------------------------------------");
        }
    }
}
