using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RegEx
{
    public class Pattern
    {
        public static void LastName(string name)
        {
            string LastName = "^[A-Z][a-zA-Z]{1,10}$"
;

            Regex regex = new Regex(LastName);
            if (regex.IsMatch(name))
            {
                Console.WriteLine(name + " is valid name");
            }
            else
            {
                Console.WriteLine(name + " is invalid. Please Enter Last name start with capital letter and maximum 10 charactors");
            }

        }
    }
}
