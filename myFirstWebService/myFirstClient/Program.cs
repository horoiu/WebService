using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace myFirstClient
{
    class Program
    {
        static void Main(string[] args)
        {
            myFirstClient.ServiceReference1.WebService1SoapClient service = new ServiceReference1.WebService1SoapClient();

            string s = service.HelloWorld();
            double suma = service.Add(5, 7);

            Console.WriteLine(s);
            Console.WriteLine("Suma este: {0}, suma");
            Console.ReadKey();
        }
    }
}
