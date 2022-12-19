using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProjectSwagLabs.Pages;
using TestProjectSwagLabs.WebDriver;

namespace TestProjectSwagLabs.Tests
{
    internal class TotalPriceTest
    {
        LoginPage loginPage;
        ProductPage productPage;
        CartPage cartPage;
        CheckoutInfoPage checkoutInfoPage;
        CheckoutOverviewPage checkoutOverviewPage;
        CheckoutCompletePage checkoutCompletePage;

        [SetUp]
        public void Setup()
        {
            WebDrivers.Initialize();
            loginPage = new LoginPage();
            productPage = new ProductPage();
            cartPage = new CartPage();
            checkoutInfoPage = new CheckoutInfoPage();
            checkoutOverviewPage = new CheckoutOverviewPage();
            checkoutCompletePage= new CheckoutCompletePage();

        }
        [TearDown]
        public void ClosePage()
        {
            WebDrivers.CleanUp();
        }

        [Test]
        public void TC01_CheckItemsTotalPrice_ItemsTotalPriceShouldBeChecked()
        {
            loginPage.LoginOnPage("standard_user", "secret_sauce");
            productPage.AddOnesie.Click();
            productPage.AddBikeLight.Click();
            productPage.AddBoltTShirt.Click();
            productPage.Cart.Click();
            cartPage.CheckoutButton.Click();
            checkoutInfoPage.FirstName.SendKeys("Milena");
            checkoutInfoPage.LastName.SendKeys("Strugarevic");
            checkoutInfoPage.ZipCode.SendKeys("11080");
            checkoutInfoPage.ContinueButton.Submit();
            Assert.That(checkoutOverviewPage.TotalPrice.Text, Is.EqualTo("Total: $36.69"));
        }

        [Test]
        public void TC02_FinishBuyingProducts_ShoppingPriceShouldBeFinished()
        {
            loginPage.LoginOnPage("standard_user", "secret_sauce");
            productPage.AddOnesie.Click();
            productPage.AddBikeLight.Click();
            productPage.AddBoltTShirt.Click();
            productPage.Cart.Click();
            cartPage.CheckoutButton.Click();
            checkoutInfoPage.FirstName.SendKeys("Milena");
            checkoutInfoPage.LastName.SendKeys("Strugarevic");
            checkoutInfoPage.ZipCode.SendKeys("11080");
            checkoutInfoPage.ContinueButton.Submit();
            checkoutOverviewPage.FinishButton.Click();
            Assert.That(checkoutCompletePage.OrderFinished.Text, Is.EqualTo("THANK YOU FOR YOUR ORDER"));
        }
    }
}
