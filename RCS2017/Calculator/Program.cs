using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Programaskaitīt
    {
        static void Main(string[] args)
        {
            // izveido kalkulēsanas ojektu
            Calculations calc;
            calc = new Calculations();

            // parasīt lietotājam vērtību
            int firstNumber = calc.AskUserForNumber();
            // paprasīt otra vērtība
            int secondNumber = calc.AskUserForNumber();

            // saskaitīt
            int result = firstNumber + secondNumber;
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
