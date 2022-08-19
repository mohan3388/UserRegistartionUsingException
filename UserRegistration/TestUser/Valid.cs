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
    }
}