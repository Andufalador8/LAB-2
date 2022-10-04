using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectsLib
{
    public class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

        private IWebElement userSelectDropdown => driver.FindElement(By.XPath("//select[@name=\"userSelect\"]"));
        public void chooseAUser()
        {
            SelectElement select = new SelectElement(userSelectDropdown);
            select.SelectByText("Nazar Trukhan");
        }

        private IWebElement loginButton => driver.FindElement(By.XPath("//button[text()=\"Login\"]"));
        public void ClickLoginButton() => loginButton.Click();
    }
}
