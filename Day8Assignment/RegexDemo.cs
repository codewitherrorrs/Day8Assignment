using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day8Assignment
{
    public class RegexDemo
    {
        //A should be Followed by 2 or more B.
        public void CheckExpression(string name)
        {
            string expression = "^[a]{1}[b]{2,3}$";
            if (Regex.IsMatch(name, expression))
            {
                Console.WriteLine($"{name} is valid String");
            }
            else
            {
                Console.WriteLine($"{name} is not a valid String");
            }
        }

        public void CheckLowercaseUnderSocre(string name)
        {
            string pattern = "^[a-z//_]+[a-z]$";
            if (Regex.IsMatch(name, pattern))
            {
                Console.WriteLine($"{name} is valid String");
            }
            else
            {
                Console.WriteLine($"{name} is not a valid String");
            }
        }
    }
}
