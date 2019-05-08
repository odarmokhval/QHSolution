using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;

namespace ConsoleAppHomeTaskQH8
{
    class FirstTestCase
    {
        IWebDriver driver;
        IWebElement element;  

        [SetUp]
        public void Initialize()
        {
            driver = new FirefoxDriver();
            //driver = new ChromeDriver();
        }

        [Test]
        public void OpenAppTest()
        {
            driver.Url = "http://www.google.com";
            driver.Manage().Window.Maximize();
            element = driver.FindElement(By.Name("q"));
            element.SendKeys("selenium webdriver");
            element.SendKeys(Keys.Enter);
        }

        [TearDown]
        public void EndTest()
        {
            driver.Quit();
        }        
    }
}
