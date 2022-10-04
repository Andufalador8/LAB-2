using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V102.Page;

namespace Tests
{
    public class BaseTest
    {
        protected IWebDriver driver;


        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.globalsqa.com/angularJs-protractor/BankingProject/#/login");
        }
        [TearDown]
        public void TearDown()
        {
            driver.Close(); 
        }
    }
}