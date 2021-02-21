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
    }
}
