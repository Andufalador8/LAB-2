using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using OpenQA.Selenium;
using PageObjectsLib;
using System;


namespace Tests
{

    public class HomeTest : BaseTest
    {
        [Test]
        public void NegativerLogin()
        {

            string name = "Nazar";
            string lastName = "Trukhan";
            string postCode = "80070";

            string depositMoney = "500";
            string withdrawlMoney = "300";

            Thread.Sleep(5000);

            HomePage home = new HomePage(driver);
            CustomerLoginPage log = new CustomerLoginPage(driver);
            LoginPage login = new LoginPage(driver);
            AccountPage acc = new AccountPage(driver);

            home.ClickBankManagerLogin();
            Thread.Sleep(1500);

            log.ClickAddCustomer();
            Thread.Sleep(1500);

            log.firstNameWrite(name);
            log.lastNameWrite(lastName);
            log.postCodeWrite(postCode);
            Thread.Sleep(1500);

            log.ClickAddCustomerButton();
            Thread.Sleep(1500);

            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();
            Thread.Sleep(1500);

            log.ClickOpenAccount();
            Thread.Sleep(1500);

            log.chooseAccount();
            log.chooseCurrency();
            Thread.Sleep(1500);

            log.clickProcessBtn();
            Thread.Sleep(1500);

            alert.Accept();
            Thread.Sleep(1500);

            home.ClickHomeButton();
            Thread.Sleep(1500);

            home.ClickCustomerLogin();
            Thread.Sleep(1500);

            login.chooseAUser();
            Thread.Sleep(1500);

            login.ClickLoginButton();
            Thread.Sleep(1500);

            acc.ClickDeposit();
            Thread.Sleep(1500);

            acc.DepositMoney(depositMoney);
            Thread.Sleep(1500);

            acc.ClickDepositBtn();
            Thread.Sleep(1500);

            acc.ClickWithdrawl();
            Thread.Sleep(1500);

            acc.WithdrawlMoney(withdrawlMoney);
            Thread.Sleep(1500);

            acc.ClickWithdrawBtn();
            Thread.Sleep(1500);

            acc.ClickTransactions();
            Thread.Sleep(3500);

        }
    }
}
