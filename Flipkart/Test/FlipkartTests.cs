using Flipkart.Base;
using Flipkart.Pages;
using NUnit.Framework;
using System;

namespace Flipkart.Test
{
    public class FlipkartTests : BaseClass
   {
        [Test]
        public void BookswagonLogin()
        {
            var login = new LoginPage(driver);
            login.AccountLogin();
            string url = "https://www.flipkart.com/";
            Assert.AreEqual(driver.Url, url);
        }
   }
}
