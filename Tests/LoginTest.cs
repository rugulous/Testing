using TestingAPI.Controllers;

namespace Tests
{
    [TestClass]
    public sealed class LoginTest
    {
        [TestMethod]
        public void Login_Success()
        {
            // Arrange
            string username = "lauren";
            string password = "password123";
            var controller = new LoginController();

            // Act
            var result = controller.Login(new LoginDetails(username, password));

            // Assert
            Assert.IsTrue(result);
        }
    }
}
