using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IFactorialService //need to change to public to get access in controller constructor (note to self)
    {

        //method for calculating the factorial
        public int giveFactorial(int number);

    }
}
