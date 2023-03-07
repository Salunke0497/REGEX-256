using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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

        public string ValidateFirstName(string name)
        {
            string FirstName = "^[A-Z][a-z]{3,}?";
            if (Regex.IsMatch(name, FirstName))
            {
                Console.WriteLine("First Name is Matching with regex");
                return name;
            }
            else
            {
                Console.WriteLine("First Name is not Matching with regex");
                return "First Name is not Matching with regex";
            }
        }

        ////checking for validate Last Name by using regex
        ////UC2
        public string ValidateLastName(string name)
        {
            string LastName = "^[A-Z][a-z]{3,}?";
            if (Regex.IsMatch(name, LastName))
            {
                Console.WriteLine("Last Name is Matching with regex");
                return name;
            }
            else
            {
                Console.WriteLine("Last Name is not Matching with regex");
                return name;
            }
        }

        ////checking for validate Email-Id by using regex
        ////UC3
        public string ValidateEmail(string email)
        {
            string EmailID = "^[a-zA-Z0-9]+[-.+_]{0,1}[a-zA-Z0-9]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}$"; //"^[a-zA-Z]+[.+_-]{0,1}[a-z]+[@][a-zA-Z]+[.][a-z]{2,3}([.][a-z]{2}){0,1}$";
            if (Regex.IsMatch(email, EmailID))
            {
                Console.WriteLine("Email-ID is Matching with regex");
                return email;
            }
            else
            {
                Console.WriteLine("Email-ID is not Matching with regex");
                return "email is not Matching with regex"; ;
            }
        }

        ////checking for validate PhoneNumber by using regex
        ////UC4
        public string ValidatePhoneNumber(string PhoneNumber)
        {
            string Phone = @"[0-9]{1,2}[ ][0-9]{10}"; //@"[0-9]{2}\s[0-9]{10}";
            if (Regex.IsMatch(PhoneNumber, Phone))
            {
                Console.WriteLine("Phone Number is Matching with regex");
                return PhoneNumber;
            }
            else
            {
                Console.WriteLine("Phone Number is not Matching with regex");
                return "Phone Number is not Matching with regex";
            }
        }

        ////checking for validate Password by using regex
        ////UC5
        public string ValidatePassword(string Password)
        {
            string PasswordRegex = @"[A-Za-z0-9]{8}";
            if (Regex.IsMatch(Password, PasswordRegex))
            {
                Console.WriteLine("Password is Matching with regex");
                return Password;
            }
            else
            {
                Console.WriteLine("Password is not Matching with regex");
                return Password;
            }
        }

        ////checking for validate Password(First Letter Capital) by using regex
        ////UC6
        public string ValidateFirstCapitalLetterPassword(string Password)
        {
            string PasswordRegex = @"[A-Z]{1}[a-z0-9]{7}";
            if (Regex.IsMatch(Password, PasswordRegex))
            {
                Console.WriteLine("Password is Matching with regex");
                return Password;
            }
            else
            {
                Console.WriteLine("Password is not Matching with regex");
                return Password;
            }
        }

        ////checking for validate Password(minimum one number in password) by using regex
        ////UC7
        public string ValidateMinimumInOneNumPassword(string Password)
        {
            string PasswordRegex2 = "[a-zA-Z][0-9]{1,}";
            if (Regex.IsMatch(Password, PasswordRegex2))
            {
                Console.WriteLine("Password is Matching with regex");
                return Password;
            }
            else
            {
                Console.WriteLine("Password is not Matching with regex");
                return "Password is not Matching with regex";
            }
        }

        ////checking for validate Password(minimum one number in password) by using regex
        ////UC8
        public string ValidateSpecialCharacterPassword(string Password)
        {
            string PasswordRegex3 = "^[A-Za-z0-9]{4}[!@#$%^&*]{1}[a-zA-Z0-9]{3}$";
            if (Regex.IsMatch(Password, PasswordRegex3))
            {
                Console.WriteLine("Password is Matching with regex");
                return Password;
            }
            else
            {
                Console.WriteLine("Password is not Matching with regex");
                return "Password is not Matching with regex";
            }
        }        
    }
}
