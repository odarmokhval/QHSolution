using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.PageObjects;

namespace ConsoleAppHomeTaskQH9.PageObjects
{
    public class HomePage  
    {
        private readonly RemoteWebDriver _driver;

        public HomePage(IWebDriver driver) => _driver = (RemoteWebDriver)driver;

        public IWebElement SearchField => _driver.FindElementByName("q");

        public IWebElement SearchButton => _driver.FindElementByName("btnK");

        public IWebElement ClickPageNumber => _driver.FindElementByXPath(".//*[@id='nav']/tbody/tr/td[3]/a");      

        public IWebElement IfLogoExist => _driver.FindElementById("hplogo");

        public void ClickOnPageNumber()
        {
            ClickPageNumber.Click();
        }

        public ResultPage Search(string text)
        {
            SearchField.SendKeys(text);
            SearchButton.Submit();
            return new ResultPage(_driver);
        }

        public void VerifyIfLogoExist()
        {
            IfLogoExist.Click();
        }
    }
}