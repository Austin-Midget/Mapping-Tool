using System;

namespace example
{
    class Program
    {
        static void Main(string args)
        {
            string currentDir = args.Split("|")[0];
            string[] arguments = args.Split("|")[1].Split(",");

            Console.WriteLine("Current directory: " + currentDir);
            Console.WriteLine("Arguments: " + string.Join(",", arguments))
        }
    }
}