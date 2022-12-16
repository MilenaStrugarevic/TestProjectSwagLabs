using TestProjectSwagLabs.Pages;
using TestProjectSwagLabs.WebDriver;

namespace TestProjectSwagLabs.Tests
{
    public class Tests
    {
        LoginPage loginPage;
        ProductPage productPage;


        [SetUp]
        public void Setup()
        {
            WebDrivers.Initialize();
            loginPage = new LoginPage();
            productPage = new ProductPage();

        }
        [TearDown]
        public void ClosePage()
        {
            WebDrivers.CleanUp();
        }

        [Test]
        public void TC01_LoginWithValidData_ShouldBeLoggedIn()
        {
            loginPage.LoginOnPage("standard_user", "secret_sauce");
            Assert.That(WebDrivers.Instance.Url, Is.EqualTo("https://www.saucedemo.com/inventory.html"));
        }

        [Test]
        public void TC02_LoginWithValidUserNameAndInvalidPassword_ShouldNotBeLoggedIn()
        {
            loginPage.LoginOnPage("standard_user", "notvalidpassword");
            Assert.That(loginPage.Message.Text, Is.EqualTo("Epic sadface: Username and password do not match any user in this service"));
        }

        [Test]
        public void TC03_LoginWithInvalidUserNameAndValidPassword_ShouldNotBeLoggedIn()
        {
            loginPage.LoginOnPage("notvaliduser", "secret_sauce");
            Assert.That(loginPage.Message.Text, Is.EqualTo("Epic sadface: Username and password do not match any user in this service"));
        }

        [Test]
        public void TC04_LoginWithNoUserNameAndNoPassword_ShouldNotBeLoggedIn()
        {
            loginPage.LoginOnPage(" ", " ");
            Assert.That(loginPage.Message.Text, Is.EqualTo("Epic sadface: Username and password do not match any user in this service"));
        }
    }
}