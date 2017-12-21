using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculations
    {
        public int AskUserForNumber()
        {
            Console.WriteLine("please enter number:");
            int number;
            string inputText = Console.ReadLine();
            number = Int32.Parse(inputText);
            return number;
        }
    }
}
