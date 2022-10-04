using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectsLib
{
    public class CustomerLoginPage : BasePage
    {
        public CustomerLoginPage(IWebDriver driver) : base(driver)
        {
        }
        private IWebElement btnAddCustomer => driver.FindElement(By.XPath("//div[@class=\"center\"]//button[1]"));
        private IWebElement btnOpenAccount => driver.FindElement(By.XPath("//div[@class=\"center\"]//button[2]"));
        private IWebElement btnCustomers => driver.FindElement(By.XPath("//div[@class=\"center\"]//button[3]"));


        private IWebElement firstNameField => driver.FindElement(By.XPath("//div[@class=\"form-group\"]//input[@ng-model=\"fName\"]"));
        private IWebElement lastNameField => driver.FindElement(By.XPath("//div[@class=\"form-group\"]//input[@ng-model=\"lName\"]"));
        private IWebElement postCodeField => driver.FindElement(By.XPath("//div[@class=\"form-group\"]//input[@ng-model=\"postCd\"]"));
        private IWebElement addCustomerBtn => driver.FindElement(By.XPath("//button[text()=\"Add Customer\"]"));


        private IWebElement customerNameDropdown => driver.FindElement(By.XPath("//select[@name=\"userSelect\"]"));
        private IWebElement currencyDropdown => driver.FindElement(By.XPath("//select[@name=\"currency\"]"));
        private IWebElement processBtn => driver.FindElement(By.XPath("//button[text()=\"Process\"]"));




        public void firstNameWrite(string text) => firstNameField.SendKeys(text);
        public void lastNameWrite(string text) => lastNameField.SendKeys(text);
        public void postCodeWrite(string text) => postCodeField.SendKeys(text);
        public void ClickAddCustomerButton() => addCustomerBtn.Click();



        public void ClickAddCustomer() => btnAddCustomer.Click();
        public void ClickOpenAccount() => btnOpenAccount.Click();
        public void ClickCustomers() => btnCustomers.Click();


        public void chooseAccount()
        {
            SelectElement select = new SelectElement(customerNameDropdown);
            select.SelectByText("Nazar Trukhan");
        }
        public void chooseCurrency()
        {
            SelectElement select = new SelectElement(currencyDropdown);
            select.SelectByText("Dollar");
        }
        public void clickProcessBtn() => processBtn.Click();
    }
}
