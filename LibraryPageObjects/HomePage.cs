using OpenQA.Selenium;
using PageObjectsLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectsLib
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {
        }
        private IWebElement btnCustomerLogin => driver.FindElement(By.XPath("//button[text()='Customer Login']"));
        private IWebElement btnBankManagerLogin => driver.FindElement(By.XPath("//button[text()='Bank Manager Login']"));
        private IWebElement btnHome => driver.FindElement(By.XPath("//button[text()=\"Home\"]"));

        public void ClickCustomerLogin() => btnCustomerLogin.Click();
        public void ClickBankManagerLogin() => btnBankManagerLogin.Click();
        public void ClickHomeButton() => btnHome.Click();
    }
}
