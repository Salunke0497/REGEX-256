﻿using System;
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
            Console.WriteLine("choose one :\n1)Validate First Name\n2)ValidateLastName\n3)ValidateEmail\n4)ValidatePhoneNumber\n5)ValidatePassword\n6)ValidateFirstCapitalLetterPassword\n7)ValidateMinimumInOneNumPassword");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    regex.ValidateFirstName("amol");
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
                case 5:
                    regex.ValidatePassword("Amol1234");
                    break;
                case 6:
                    regex.ValidateFirstCapitalLetterPassword("Amol1234");
                    break;
                case 7:
                    regex.ValidateMinimumInOneNumPassword("Amol1123");
                    break;
                case 8:
                    regex.ValidateMinimumInOneNumPassword("Amol1123");
                    break;
                default:
                    break;
            }                   
            Console.ReadLine();
        }
    }
}
