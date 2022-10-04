using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectsLib
{
    public class AccountPage : BasePage
    {
        public AccountPage(IWebDriver driver) : base(driver)
        {
        }

        private IWebElement btnTransactions => driver.FindElement(By.XPath("//div[@class=\"center\"]//button[1]"));
        private IWebElement btnDeposit => driver.FindElement(By.XPath("//div[@class=\"center\"]//button[2]"));
        private IWebElement btnWithdrawl => driver.FindElement(By.XPath("//div[@class=\"center\"]//button[3]"));
        public void ClickTransactions() => btnTransactions.Click();
        public void ClickDeposit() => btnDeposit.Click();
        public void ClickWithdrawl() => btnWithdrawl.Click();


        private IWebElement depositBtn => driver.FindElement(By.XPath("//button[text()=\"Deposit\"]"));
        private IWebElement depositField => driver.FindElement(By.XPath("//div[@class=\"form-group\"]//input[@ng-model=\"amount\"]"));
        public void ClickDepositBtn() => depositBtn.Click();
        public void DepositMoney(string text) => depositField.SendKeys(text);


        private IWebElement withdrawBtn => driver.FindElement(By.XPath("//button[text()=\"Withdraw\"]"));
        private IWebElement withrawlField => driver.FindElement(By.XPath("//div[@class=\"form-group\"]//input[@ng-model=\"amount\"]"));
        public void ClickWithdrawBtn() => withdrawBtn.Click();
        public void WithdrawlMoney(string text) => depositField.SendKeys(text);
    }
}
