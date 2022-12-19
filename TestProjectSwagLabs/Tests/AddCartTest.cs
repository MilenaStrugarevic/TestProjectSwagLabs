using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProjectSwagLabs.Pages;
using TestProjectSwagLabs.WebDriver;

namespace TestProjectSwagLabs.Tests
{
    public class AddCartTest
    {
        LoginPage loginPage;
        ProductPage productPage;
        CartPage cartPage;

        [SetUp]
        public void Setup()
        {
            WebDrivers.Initialize();
            loginPage = new LoginPage();
            productPage = new ProductPage();
            cartPage = new CartPage();

        }
        [TearDown]
        public void ClosePage()
        {
            WebDrivers.CleanUp();
        }

        [Test]
        public void TC01_SortProductsByPriceLowToHigh_ShouldSortProductByPriceLowToHigh()
        {
            loginPage.LoginOnPage("standard_user", "secret_sauce");
            productPage.SelectSortOption("Price (low to high)");
            Assert.That(productPage.SortByPrice.Displayed);
        }
        [Test]
        public void TC02_AddTwoProductsInCart_ShouldDisplayTwoProducts()
        {
            loginPage.LoginOnPage("standard_user", "secret_sauce");
            productPage.AddOnesie.Click();
            productPage.AddBikeLight.Click();
            productPage.AddBoltTShirt.Click();
            Assert.That(productPage.Cart.Text, Is.EqualTo("3"));
        }
        
    }
}
