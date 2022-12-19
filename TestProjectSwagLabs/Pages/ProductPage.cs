using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TestProjectSwagLabs.WebDriver;

namespace TestProjectSwagLabs.Pages
{
    public class ProductPage
    {
        public IWebDriver driver = WebDrivers.Instance;
        public IWebElement SortByPrice => driver.FindElement(By.ClassName("product_sort_container"));
        public void SelectSortOption(string text)
        {
            SelectElement element = new SelectElement(SortByPrice);
            element.SelectByText(text);
        }
        public IWebElement AddOnesie => driver.FindElement(By.Id("add-to-cart-sauce-labs-onesie"));
        public IWebElement AddBikeLight => driver.FindElement(By.Id("add-to-cart-sauce-labs-bike-light"));
        public IWebElement AddBoltTShirt => driver.FindElement(By.Id("add-to-cart-sauce-labs-bolt-t-shirt"));
        public IWebElement Cart => driver.FindElement(By.Id("shopping_cart_container"));

    }
}
