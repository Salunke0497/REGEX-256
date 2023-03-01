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
            Console.WriteLine("choose one :\n1)Validate First Name");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    regex.ValidateFirstName("Amol");
                    break;
                case 2:
                    regex.ValidateLastName("Salunke");
                    break;
                case 3:
                    regex.ValidateEmail("abc.xyz@bridgelabz.co.in");
                    break;
                case 4:
                    regex.ValidatePhoneNumber("91 8390266064");
                    break;
                default:
                    break;
            }                   
            Console.ReadLine();
        }
    }
}
