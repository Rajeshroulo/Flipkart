using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Threading;

namespace Flipkart.Pages
{
    public class HomePage
   {

        public IWebDriver driver;
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Search for products, brands and more']")]
        public IWebElement SearchBox;
        
        [FindsBy(How = How.XPath, Using = "//button[@class='vh79eN']//*[local-name()='svg']")]
        public IWebElement SearchButton;

        [FindsBy(How = How.XPath, Using = "//body/div[@id='container']/div[1]/div[3]/div[2]/div[1]/div[2]/div[2]/div[1]/div[1]/div[1]/a[1]/div[2]/div[1]/div[1]")]
        public IWebElement samsungPhone;

        public void SearchMobile()
        {
            SearchBox.Click();
            SearchBox.SendKeys("Samsung Guru Music 2");
            SearchButton.Click();
            Thread.Sleep(10000);
            samsungPhone.Click();
            Thread.Sleep(7000);
        }

   }
}
