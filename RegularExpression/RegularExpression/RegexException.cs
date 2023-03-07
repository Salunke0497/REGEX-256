using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using static RegularExpression.UserRegistrationCustomException;

namespace RegularExpression
{
    public class RegexException
    {
        string message;

        public RegexException(string message)
        {
            this.message = message;
        }
        public string ValidateFirstNameException()
        {
            string FirstName = "^[A-Z][a-z]{3,}?";
            try
            {
                if (message.Equals(string.Empty))
                {
                    throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.EMPTY_INPUT, "Message should not be empty");
                }
                else if (Regex.IsMatch(message, FirstName))
                {
                    Console.WriteLine("First Name is Matching with regex");
                    return "Name is Valid";
                }
                else
                {
                    Console.WriteLine("First Name is not Matching with regex");
                    return "First Name is not Matching with regex";
                }
            }
            catch (NullReferenceException)
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.NULL_INPUT, "Message should not be null");
            }
        }
        public string ValidateLastNameException()
        {
            string LastName = "^[A-Z][a-z]{3,}?";
            try
            {
                if (message.Equals(string.Empty))
                {
                    throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.EMPTY_INPUT, "Message should not be empty");
                }
                else if (Regex.IsMatch(message, LastName))
                {
                    Console.WriteLine("Last Name is Matching with regex");
                    return "Name is Valid";
                }
                else
                {
                    Console.WriteLine("Last Name is not Matching with regex");
                    return "Last Name is not Matching with regex";
                }
            }
            catch (NullReferenceException)
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.NULL_INPUT, "Message should not be null");
            }
        }
        public string ValidateEmailException()
        {
            //abc.xyz@bl.co.in
            string emailPatten = "^[a-zA-Z]+[.+_-]{0,1}[a-z]+[@][a-zA-Z]+[.][a-z]{2,3}([.][a-z]{2}){0,1}$";
            try
            {
                if (message.Equals(string.Empty))
                {
                    throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.EMPTY_INPUT, "Email should not be Empty");
                }
                if (Regex.IsMatch(message, emailPatten))
                {
                    Console.WriteLine("Email is Valid");
                    return "Email is Valid";
                }
                else
                {
                    Console.WriteLine("Email not Valid ");
                    return "Email is Valid";
                }
            }
            catch (NullReferenceException)
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.NULL_INPUT, "Email should not be Null");
            }
        }
        public string ValidateMobileNumberException()
        {
            string mobileNumberPatten = @"[0-9]{1,2}[ ][0-9]{10}"; /*@"[0-9]{1,2}\s[0-9]{10}"*/
            try
            {
                if (message.Equals(string.Empty))
                {
                    throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.EMPTY_INPUT, "Mobile Number should not be Empty");
                }
                if (Regex.IsMatch(message, mobileNumberPatten))
                {
                    Console.WriteLine("Mobile Number is Valid");
                    return "Mobile Number is Valid";
                }
                else
                {
                    Console.WriteLine("Mobile Number not Valid");
                    return "Mobile Number not Valid";
                }
            }
            catch (NullReferenceException)
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.NULL_INPUT, "Mobile Number should not be Null");
            }
        }
        public string ValidatePasswordRoule1Exception()
        {
            string passwordPatten = @"[A-Z a-z 0-9]{8,}";
            if (Regex.IsMatch(message, passwordPatten))
            {
                Console.WriteLine("Password is Valid");
                return "Password is Valid";
            }
            else
            {
                Console.WriteLine("Password not Valid ");
                return "Password not Valid";
            }
        }
        public string ValidatePasswordRoule2Exception()
        {
            string passwordPatten = "(?=.*[A-Z])[A-Za-z0-9]{8,}";
            if (Regex.IsMatch(message, passwordPatten))
            {
                Console.WriteLine("Password is Valid");
                return "Password is Valid";
            }
            else
            {
                Console.WriteLine("Password not Valid ");
                return "Password not Valid";
            }
        }
        public string ValidatePasswordRoule3Exception()
        {
            string passwordPatten = "(?=.*[A-Z])(?=.*[0-9])[A-Za-z0-9]{8,}";
            if (Regex.IsMatch(message, passwordPatten))
            {
                Console.WriteLine("Password is Valid");
                return "Password is Valid";
            }
            else
            {
                Console.WriteLine("Password not Valid ");
                return "Password not Valid";
            }
        }
        public string ValidatePasswordRoule4Exception()
        {
            string passwordPatten = "^(?=.*?[A-Z])(?=.*?[0-9])(?=.*?[!@#$%^&*()_+=-]).{8,}$"; // "(?=.*[A-Z])(?=.*[0-9])(?=.*[*#@$!^_-])[A-Za-z0-9]{8,}"

            if (Regex.IsMatch(message, passwordPatten))
            {
                Console.WriteLine("Password is Valid");
                return "Password is Valid";
            }
            else
            {
                Console.WriteLine("Password not Valid ");
                return "Password not Valid";
            }
        }

    }
}
