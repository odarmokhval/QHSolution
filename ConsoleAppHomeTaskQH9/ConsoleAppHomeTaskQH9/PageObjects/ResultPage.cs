using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;

namespace ConsoleAppHomeTaskQH9.PageObjects
{
    public class ResultPage
    {
        private readonly RemoteWebDriver _driver;

        public ResultPage(IWebDriver driver) => _driver = (RemoteWebDriver)driver;

        public IWebElement FindPageLogo => _driver.FindElementById("logo");        

        public void PageLogo()
        {
            FindPageLogo.Click();
        }                     
    }
}