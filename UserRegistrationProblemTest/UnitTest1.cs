using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationProblem;
namespace UserRegistrationProblemTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenPasswordWhenMachShouldReturnTrue()
        {
            UserValidation userValidation = new UserValidation();
            bool result = userValidation.CheckPassword("ankitsingh");
            Assert.AreEqual(true, result);
        }
    }
}
