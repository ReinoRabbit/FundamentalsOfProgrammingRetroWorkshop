using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface IReverseService //make public for access reasons
    {

        //method for string manipulation (reverse method)
        public string reverseString(string sentence);

    }
}
