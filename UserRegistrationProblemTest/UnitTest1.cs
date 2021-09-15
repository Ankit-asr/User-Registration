using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationProblem;
namespace UserRegistrationProblemTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenPasswordCheckShouldReturnTrue()
        {
            UserValidation userValidation = new UserValidation();
            bool result = userValidation.CheckPassword("ankitSingh8");
            Assert.AreEqual(true, result);
        }
    }
}
