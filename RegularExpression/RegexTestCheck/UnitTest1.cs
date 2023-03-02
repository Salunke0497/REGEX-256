using RegularExpression;

namespace RegexTestCheck
{
    [TestClass]
    public class UnitTest1
    {
        RegexClass regexTest = new RegexClass();
        [TestMethod]
        public void TestMethod1()
        {
            string firstName = regexTest.ValidateFirstName("Amol");
            Assert.AreEqual(firstName, "Amol");
        }
        [TestMethod]
        public void Test2()
        {
            string LastName = regexTest.ValidateFirstName("Salunke");
            Assert.AreEqual(LastName, "Salunke");
        }
        [TestMethod]
        public void Test3()
        {

            string Email = regexTest.ValidateFirstName("abc.xyz@bridgelabz.co.in");
            Assert.AreEqual(Email, "abc.xyz@bridgelabz.co.in");
        }
        [TestMethod]
        public void Test4()
        {
            string Phone = regexTest.ValidateFirstName("91 8390266064");
            Assert.AreEqual(Phone, "91 8390266064");
        }
        [TestMethod]
        public void TestCase_Validate_FirstLetterCapital_Password()
        {
            string passwordOne = regexTest.ValidateFirstName("Amol1234");
            Assert.AreEqual(passwordOne, "Amol1234");
        }
        [TestMethod]
        public void TestCase_Validate_MinimumOneNum_Password()
        {
            string passwordTwo = regexTest.ValidateFirstName("Amol1234");
            Assert.AreEqual(passwordTwo, "Amol1234");
        }
        [TestMethod]
        public void TestCase_Validate_SpecialCharacter_Password()
        {
            string passwordThree = regexTest.ValidateSpecialCharacterPassword("Amol1234");
            Assert.AreEqual(passwordThree, "Amol1234");
        }
    }
}