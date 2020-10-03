using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Threading;

namespace Flipkart.Pages
{
    public class CartPage
    {
        public IWebDriver driver;
        public CartPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//body/div[@id='container']/div[1]/div[3]/div[1]/div[1]/div[2]/div[1]/ul[1]/li[2]/form[1]/button[1]")]
        public IWebElement buyNow;

        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'CONTINUE')]")]
        public IWebElement continueBtn;
        
        public void AddtoCart()
        {
            Thread.Sleep(3000);
            buyNow.Click();
            Thread.Sleep(10000);
            continueBtn.Click();
            Thread.Sleep(2000);
        }
    }
}
