using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RegularExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RegexClass regex = new RegexClass();
            regex.ValidateFirstName("Amol");       
            Console.ReadLine();
        }
    }
}
