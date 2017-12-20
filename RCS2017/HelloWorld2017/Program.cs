using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld2017
{
    class Program
    {
        static void Main(string[] args)
        {
            Mainigie greet;
            greet = new Mainigie();
            greet.HelloText = "Hello World!";
            greet.SayHello();

            Mainigie seaGreet;
            seaGreet = new Mainigie();
            seaGreet.HelloText = "Ahou World!";
            seaGreet.SayHello();

            Console.ReadLine();
        }
    }
}
