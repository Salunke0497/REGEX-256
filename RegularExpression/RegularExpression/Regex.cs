using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RegularExpression
{
    public class RegexClass
    {
        //checking for validate First Name by using regex
        //UC1
        public void ValidateFirstName(string name)
        {
            string FirstName = "^[A-Z][a-z]{3,}?";
            if(Regex.IsMatch(name,FirstName))
            {
                Console.WriteLine("First Name is Matching with regex");
            }
            else
            {
                Console.WriteLine("First Name is not Matching with regex");
            }
        }
        //checking for validate Last Name by using regex
        //UC2
        public void ValidateLastName(string name)
        {
            string LastName = "^[A-Z][a-z]{3,}?";
            if (Regex.IsMatch(name, LastName))
            {
                Console.WriteLine("Last Name is Matching with regex");
            }
            else
            {
                Console.WriteLine("Last Name is not Matching with regex");
            }
        }
        //checking for validate Email-Id by using regex
        //UC3
        public void ValidateEmail(string email)
        {
            string EmailID = "^[a-zA-Z]+[.+_-]{0,1}[a-z]+[@][a-zA-Z]+[.][a-z]{2,3}([.][a-z]{2}){0,1}$";
            if (Regex.IsMatch(email, EmailID))
            {
                Console.WriteLine("Email-ID is Matching with regex");
            }
            else
            {
                Console.WriteLine("Email-ID is not Matching with regex");
            }
        }

    }
}
