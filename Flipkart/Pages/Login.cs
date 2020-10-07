using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Configuration;
using System.Threading;

namespace Flipkart.Pages
{
    public class Login
    {
        public IWebDriver driver;
        string email = ConfigurationManager.AppSettings["email"];
        string password = ConfigurationManager.AppSettings["password"];

        public Login(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//input[@class='_2zrpKA _1dBPDZ']")]
        public IWebElement mail;

        [FindsBy(How = How.XPath, Using = "//input[@class='_2zrpKA _3v41xv _1dBPDZ']")]
        public IWebElement passWord;

        [FindsBy(How = How.XPath, Using = "//button[@class='_2AkmmA _1LctnI _7UHT_c']//span[contains(text(),'Login')]")]
        public IWebElement loginButton;

        public void AccountLogin()
        {
            Thread.Sleep(3000);
            mail.SendKeys(email);
            passWord.SendKeys(password);
            loginButton.Click();
            Thread.Sleep(5000);
        }

    }
}
