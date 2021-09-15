using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistrationProblem;
namespace UserRegistrationProblemTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenFirstNameWhenCheckShouldBeReturnTrue()
        {
            UserValidation userValidation = new UserValidation();
            bool result = userValidation.CheckFirstName("Ankit");
            Assert.AreEqual(true, result);
        }
    }
}
