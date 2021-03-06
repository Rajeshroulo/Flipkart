﻿using Flipkart.Base;
using Flipkart.Pages;
using NUnit.Framework;
using System;

namespace Flipkart.Test
{
    public class FlipkartTests : BaseClass
    {
        [Test, Order(1)]
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
        }

        [Test, Order(3)]
        public void BuyProduct()
        {
            var product = new CartPage(driver);
            product.AddtoCart();
            string url = "https://www.flipkart.com/checkout/init?otracker=search";
            Assert.AreEqual(driver.Url, url);
        }

        [Test, Order(4)]
        public void AccountLogout()
        {
            var logout = new LogoutPage(driver);
            logout.FlipkartLogout();
            string title = "Online Shopping Site for Mobiles, Electronics, Furniture, Grocery, Lifestyle, Books & More. Best Offers!";
            Assert.AreEqual(driver.Title, title);
        }

        [Test, Order(5)]
        public void FlipkartAccountLogin()
        {
            var login = new Login(driver);
            login.AccountLogin();
            string url = "https://www.flipkart.com/";
            Assert.AreEqual(driver.Url, url);
        }
    }
}
