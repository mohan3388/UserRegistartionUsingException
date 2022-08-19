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
    }
}