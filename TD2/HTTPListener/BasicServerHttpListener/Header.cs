using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace HttpRequestHeader
{
    class Header
    {
        public void getHeader(HttpListenerRequest request)
        {
            System.Collections.Specialized.NameValueCollection headers = request.Headers;
            // Get each header and display each value.
            foreach (string key in headers.AllKeys)
            {
                string[] values = headers.GetValues(key);
                if (values.Length > 0)
                {

                    Console.WriteLine("The values of the {0} header are: ", key);
                    foreach (string value in values)
                    {
                           Console.WriteLine("   {0}", value);
                    }
                }
                else
                {
                    Console.WriteLine("There is no value associated with the header.");
                }
            }
        }
    }
}
