using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProjectSwagLabs.WebDriver;

namespace TestProjectSwagLabs.Pages
{
    public class CheckoutInfoPage
    {
        private IWebDriver driver = WebDrivers.Instance;
        public IWebElement FirstName => driver.FindElement(By.Id("first-name"));
        public IWebElement LastName => driver.FindElement(By.Id("last-name"));
        public IWebElement ZipCode => driver.FindElement(By.Id("postal-code"));
        public IWebElement ContinueButton => driver.FindElement(By.Id("continue"));
    }
}
