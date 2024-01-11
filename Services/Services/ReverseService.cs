using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class ReverseService : IReverseService //inherit to access method and make public for dependency
    {

        //logic for the reverse string method
        public string reverseString(string sentence)
        {
            string x = sentence; //save sentence into placeholder
            string[] words = x.Split(' '); //split sentence at spaces and add elements into array
            Array.Reverse(words); //reverse the array of elements
            string revsentence = string.Join(" ", words); //rejoin the elements to for sentence
            return revsentence; //return as this is not void method
            //from research with string manipulations^^^
        }

    }
}
