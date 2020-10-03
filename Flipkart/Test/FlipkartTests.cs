using Flipkart.Base;
using Flipkart.Pages;
using NUnit.Framework;
using System;

namespace Flipkart.Test
{
    public class FlipkartTests : BaseClass
    {
        [Test,Order(1)]
        public void FlipkartLogin()
        {
            var login = new LoginPage(driver);
            login.AccountLogin();
            string url = "https://www.flipkart.com/";
            Assert.AreEqual(driver.Url, url);
        }

        [Test, Order(2)]
        public void SearchProduct()
        {
            var product = new HomePage(driver);
            product.SearchMobile();
            string title = "Samsung Guru Music 2 - Buy Products Online at Best Price in India - All Categories | Flipkart.com";
            Assert.AreEqual(driver.Title, title);
        }
    }
}
