using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProjectSwagLabs.WebDriver;

namespace TestProjectSwagLabs.Pages
{
    public class CheckoutCompletePage
    {
        private IWebDriver driver = WebDrivers.Instance;
        public IWebElement OrderFinished => driver.FindElement(By.ClassName("complete-header"));
    }
}
