﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProjectSwagLabs.WebDriver;

namespace TestProjectSwagLabs.Pages
{
    public class CartPage
    {
        public IWebDriver driver = WebDrivers.Instance;
        public IWebElement CheckoutButton => driver.FindElement(By.Id("checkout"));
    }
}
