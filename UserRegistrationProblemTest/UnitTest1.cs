using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationProblem;
namespace UserRegistrationProblemTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenMobileNumberCheckShouldBeReturnTrue()
        {
            UserValidation userValidation = new UserValidation();
            bool result = userValidation.CheckPassword("ankitSingh");
            Assert.AreEqual(true, result);
        }
    }
}
