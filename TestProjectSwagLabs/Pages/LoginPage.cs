using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProjectSwagLabs.WebDriver;

namespace TestProjectSwagLabs.Pages
{
    public class LoginPage
    {
        public IWebDriver driver = WebDrivers.Instance;
        public IWebElement Username => driver.FindElement(By.Id("user-name"));
        public IWebElement Password => driver.FindElement(By.Id("password"));
        public IWebElement LoginButton => driver.FindElement(By.Id("login-button"));
        public IWebElement Message => driver.FindElement(By.XPath("//*[@id=\"login_button_container\"]/div/form/div[3]"));

        public void LoginOnPage(string name, string password)
        {
            Username.SendKeys(name);
            Password.SendKeys(password);
            LoginButton.Submit();
        }
    }
}
