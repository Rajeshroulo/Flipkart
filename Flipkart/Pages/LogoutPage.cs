using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Flipkart.Pages
{
   public class LogoutPage
   {

        public IWebDriver driver;
        public LogoutPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//img[@class='_1e_EAo']")]
        public IWebElement homeButton;
        
        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Rajesh kumar')]")]
        public IWebElement myAccount;
        
        [FindsBy(How = How.XPath, Using = "//body/div[@id='container']/div/div/div/div/div[3]/div[1]/div[1]/div[1]")]
        public IWebElement dropdownButton;
        
        [FindsBy(How = How.XPath, Using = "//body//div[@id='container']//div//div//div//div//div//li[10]//a[1]")]
        public IWebElement logoutButton;

        public void FlipkartLogout()
        {
            Thread.Sleep(3000);
            homeButton.Click();
            Thread.Sleep(5000);
            myAccount.Click();
            Thread.Sleep(3000);
            dropdownButton.Click();
            Thread.Sleep(2000);
            logoutButton.Click();
            Thread.Sleep(3000);
        }


    }
}
