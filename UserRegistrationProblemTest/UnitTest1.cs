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
            bool result = userValidation.CheckPassword("ankitSin8@");
            Assert.AreEqual(true, result);
        }
    }
}
