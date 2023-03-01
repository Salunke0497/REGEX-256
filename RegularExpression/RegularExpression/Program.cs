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
                default:
                    break;
            }                   
            Console.ReadLine();
        }
    }
}
