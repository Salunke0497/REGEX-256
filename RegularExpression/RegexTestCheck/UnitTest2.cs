using RegularExpression;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexTestCheck
{
    public class UnitTest2
    {
        //[TestMethod]
        //public void Given_Empty_FirstName_Should_Throw_UserRegistrationException_Indicating_EmptyInput()
        //{
        //    try
        //    {
        //        RegexException exceptionCheck = new RegexException(string.Empty);
        //        string firstName = exceptionCheck.ValidateFirstNameException();
        //    }
        //    catch (Exception obj)
        //    {
        //        Assert.AreEqual("Message should not be empty", obj.Message);
        //    }
        //}
        //[TestMethod]
        //public void Given_Empty_LastName_Should_Throw_UserRegistrationException_Indicating_EmptyInput()
        //{
        //    try
        //    {
        //        RegexException exceptionCheck = new RegexException(string.Empty);
        //        string firstName = exceptionCheck.ValidateLaststNameException();
        //    }
        //    catch (Exception obj)
        //    {
        //        Assert.AreEqual("Message should not be empty", obj.Message);
        //    }
        //}
        [TestMethod]
        public void Given_Empty_FirstName_Should_Throw_UserRegistrationException_Indicating_EmptyInput()
        {
            try
            {
                RegexException exceptionCheck = new RegexException(string.Empty);
                string firstName = exceptionCheck.ValidateLaststNameException();
            }
            catch (UserRegistrationCustomException ex)
            {
                Assert.AreEqual("First Name should not be Empty", ex.Message);
            }

        }
        [TestMethod]
        public void Given_NULL_FirstName_Should_Throw_UserRegistrationException()
        {
            try
            {
                RegexException exceptionCheck = new RegexException(null);
                string firstName = exceptionCheck.ValidateLaststNameException();
            }
            catch (UserRegistrationCustomException ex)
            {
                Assert.AreEqual("First Name should not be Null", ex.Message);
            }
        }
        [TestMethod]
        public void Given_Empty_LastName_Should_Throw_UserRegistrationException_Indicating_EmptyInput()
        {
            try
            {
                RegexException exceptionCheck = new RegexException(string.Empty);
                string LastName = exceptionCheck.ValidateLaststNameException();
            }
            catch (UserRegistrationCustomException ex)
            {
                Assert.AreEqual("Last Name should not be Empty", ex.Message);
            }
        }
        [TestMethod]
        public void Given_NULL_LastName_Should_Throw_UserRegistrationException()
        {
            try
            {
                RegexException exceptionCheck = new RegexException(null);
                string LastName = exceptionCheck.ValidateLaststNameException();
            }
            catch (UserRegistrationCustomException ex)
            {
                Assert.AreEqual("Last Name should not be Null", ex.Message);
            }
        }
        [TestMethod]
        public void Given_Empty_Email_Should_Throw_UserRegistrationException_Indicating_EmptyInput()
        {
            try
            {
                RegexException exceptionCheck = new RegexException(null);
                string email = exceptionCheck.ValidateLaststNameException();
            }
            catch (UserRegistrationCustomException ex)
            {
                Assert.AreEqual("Email should not be Empty", ex.Message);
            }
        }
        [TestMethod]
        public void Given_NULL_Email_Should_Throw_UserRegistrationException()
        {
            try
            {
                RegexException exceptionCheck = new RegexException(null);
                string email = exceptionCheck.ValidateLaststNameException();
            }
            catch (UserRegistrationCustomException ex)
            {
                Assert.AreEqual("Email should not be Null", ex.Message);
            }
        }
        [TestMethod]
        public void Given_Empty_Mobile_Should_Throw_UserRegistrationException_Indicat()
        {
            try
            {
                RegexException exceptionCheck = new RegexException(null);
                string firstName = exceptionCheck.ValidateLaststNameException(); ;
            }
            catch (UserRegistrationCustomException ex)
            {
                Assert.AreEqual("Mobile Number should not be Empty", ex.Message);
            }
        }
        [TestMethod]
        public void Given_NULL_MobileNumber_Should_Throw_UserRegistrationException()
        {
            try
            {
                RegexException exceptionCheck = new RegexException(null);
                string firstName = exceptionCheck.ValidateLaststNameException();
            }
            catch (UserRegistrationCustomException ex)
            {
                Assert.AreEqual("Mobile Number should not be Null", ex.Message);
            }
        }
    }
}