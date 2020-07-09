using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
           // Tuple<String, int, bool> myTuple = new Tuple<string, int, bool>("yikes", 5, false);

            var myTuple = Tuple.Create(5, "shucks", true);
            Console.WriteLine(myTuple.Item1);
        }
    }
}
