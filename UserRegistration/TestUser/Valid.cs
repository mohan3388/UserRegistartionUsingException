using UserRegistration;

namespace TestUser
{
    [TestClass]
    public class Valid
    {
        [TestMethod]
        public void User_Valid_name()
        {
            User valid = new User();
            bool actual = valid.FNameValidation("Mohan");

            Assert.IsTrue(actual);
        }
        [TestMethod]
        public void User_Valid_lastname()
        {
            User valid = new User();
            bool actual = valid.LNameValidation("Sahu");

            Assert.IsTrue(actual);
        }
        [TestMethod]
        public void User_Valid_Email()
        {
            User valid = new User();
            bool actual = valid.EmailValidation("abc.xyz@bl.co.in");
           Assert.IsTrue(actual);
        }
        [TestMethod]
        public void User_Valid_Mobile()
        {
            User valid = new User();
            bool actual = valid.MobileValidation("91 7898625487");
            Assert.IsTrue(actual);
        }
        [TestMethod]
        public void User_Valid_password()
        {
            User valid = new User();
            bool actual = valid.PasswordValidation("mohansahu");
            Assert.IsTrue(actual);
        }
        [TestMethod]
        public void User_Valid_Password_Include_One_Uppercase()
        {
            User valid = new User();
            bool actual = valid.PassIncludeOneUppercase("Mohansahu");
            Assert.IsTrue(actual);
        }
        [TestMethod]
        public void User_Valid_Password_Include_One_Numeric()
        {
            User valid = new User();
            bool actual = valid.PassIncludeOneNumeric("Mohansa12");
            Assert.IsTrue(actual);
        }
        [TestMethod]
        public void User_Valid_Password_Include_One_Specialchar()
        {
            User valid = new User();
            bool actual = valid.PassIncludeOneSpecialChar("Mohansa@12");
            Assert.IsTrue(actual);
        }
        [TestMethod]
        public void User_Valid_All_sample_Email()
        {
            User valid = new User();
            bool actual = valid.AllSampleEmail("abc@yahoo.com");
            Assert.IsTrue(actual);
        }
    }
}