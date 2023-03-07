using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            regex.ValidateLastName("Salunke");
            regex.ValidateEmail("abc.xyz@bridgelabz.co.in");
            regex.ValidatePhoneNumber("91 8390266064");
            regex.ValidatePassword("Amol1234");
            regex.ValidateFirstCapitalLetterPassword("Amol1234");
            regex.ValidateMinimumInOneNumPassword("Amolsal3");
            regex.ValidateMinimumInOneNumPassword("Amo5@234");
            Console.ReadLine();
        }
            
    }
}
