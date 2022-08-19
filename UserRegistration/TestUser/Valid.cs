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
    }
}