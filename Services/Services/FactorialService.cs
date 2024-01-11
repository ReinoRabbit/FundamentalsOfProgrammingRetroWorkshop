using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    internal class FactorialService : IFactorialService //inherit interface so we can get method in service
    {

        //logic for the factorial method
        public int giveFactorial(int number)
        {
            //while loop for adding numbers
            int result = 1;
            while (number != 1)
            {
                result *= number;
                number = number - 1;
            }

            //method needs return as its not void and contains result
            return result;
        }

    }
}
