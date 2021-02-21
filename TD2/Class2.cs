using System;

public class Class1
{
	public Class1()
	{
        static void Main(string[] args)
        {
            if (args.Length == 2)
                Console.WriteLine("<HTML><BODY> Hello " + args[0] + " et " + args[1] + "</BODY></HTML>");
            else
                Console.WriteLine("ExeTest <string parameter>");

        }
    }
}
