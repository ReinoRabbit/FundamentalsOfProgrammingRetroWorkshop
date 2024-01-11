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
            //for loop for adding numbers


            //method needs return as its not void
            return number;
        }

    }
}
