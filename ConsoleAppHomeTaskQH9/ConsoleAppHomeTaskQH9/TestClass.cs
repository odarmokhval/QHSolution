using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using ConsoleAppHomeTaskQH9.PageObjects;

namespace ConsoleAppHomeTaskQH9ConsoleAppHomeTaskQH9
{
    [TestFixture]
    public class TestFirst
    {
        [Test]
        public void Selenium123()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://google.com");

            HomePage homePage = new HomePage(driver);

            var resultPage = homePage.Search("BrainStorm");

            homePage.ClickOnPageNumber();
            resultPage.PageLogo();
            homePage.VerifyIfLogoExist();        

            driver.Quit();
        }
    }
}