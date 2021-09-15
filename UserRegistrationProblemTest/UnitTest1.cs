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
<<<<<<< HEAD
            bool result = userValidation.CheckPassword("ankitsingh");
=======
            bool result = userValidation.CheckPassword("ankitSingh");
>>>>>>> UC6-PasswordValidationRule2
            Assert.AreEqual(true, result);
        }
    }
}
