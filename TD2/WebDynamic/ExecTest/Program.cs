using System;

namespace ExeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 2)
                Console.WriteLine(args[0]);
            else
                Console.WriteLine("ExeTest <string parameter>");
        }

    }
}
