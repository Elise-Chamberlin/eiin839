using System;
using System.Diagnostics;
using System.IO;

namespace BasicServerHTTPlistener
{
    class MyMethods
    {
        public string myMethod(string param1_value, string param2_value)
        {
            return ("<HTML><BODY> Hello " + param1_value + " et " + param2_value + "</BODY></HTML>");
        }

        public void myMethodExtern(string param1_value, string param2_value)
        {
            ProcessStartInfo start = new ProcessStartInfo();
            //start.FileName = @"D:\MesDossiers\Documents\Cours\POLYTECH\SEMESTRE8\Soc_WB\TD1\eiin839\TD2\BasicWebServer\hello.sh"; // pour executer un script bash décommenter cette ligne et la suivante et mettre en commentaire la suite du code
            //Process process = Process.Start(start); 

            start.FileName = @"D:\MesDossiers\Documents\Cours\POLYTECH\SEMESTRE8\Soc_WB\TD1\eiin839\TD2\myMethodExtern\bin\Debug\netcoreapp3.1\myMethodExtern.exe"; // Specify exe name.
            start.Arguments = param1_value + " " + param2_value; // Specify arguments.
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            //
            // Start the process.
            //
            
            using (Process process = Process.Start(start))
            {
                //
                // Read in all the text from the process with the StreamReader.
                //
                using (StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    Console.WriteLine(result);
                }
            }
        }
    }
}
