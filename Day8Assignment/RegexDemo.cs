using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day8Assignment
{
    public class RegexDemo
    {
        public void CheckExpression(string name)
        {
            string expression = "[a]{1}[b]{2,3}$";
            if (Regex.IsMatch(name, expression))
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
