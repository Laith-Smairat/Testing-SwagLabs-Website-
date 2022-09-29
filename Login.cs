using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwagLabs2
{
    [TestClass]
    public class Login
    {
        [TestMethod]
        /* Login With standard_user */
        public static void LoginTest()
        {
            TestSetup.NavigateToUrl(TestSetup.driver, TestSetup.url);
            System.Threading.Thread.Sleep(5000);
            IWebElement usernameInput = TestSetup.driver.FindElement(By.XPath("//div/input[@id='user-name']"));
            TestSetup.HighlightElement(TestSetup.driver, usernameInput);
            usernameInput.SendKeys("standard_user");
            System.Threading.Thread.Sleep(1000);

            IWebElement passwordInput = TestSetup.driver.FindElement(By.XPath("//div/input[@id='password']"));
            TestSetup.HighlightElement(TestSetup.driver, passwordInput);
            passwordInput.SendKeys("secret_sauce");
            System.Threading.Thread.Sleep(1000);

            IWebElement loginBtn = TestSetup.driver.FindElement(By.XPath("//div//input[@id='login-button']"));
            TestSetup.HighlightElement(TestSetup.driver, loginBtn);
            loginBtn.Click();
            System.Threading.Thread.Sleep(5000);

        }


        [TestMethod]
        /* Login With problem_user */
        public static void LoginWithProblemUser()
        {
            TestSetup.NavigateToUrl(TestSetup.driver, TestSetup.url);
            System.Threading.Thread.Sleep(5000);

            IWebElement usernameInput = TestSetup.driver.FindElement(By.XPath("//div/input[@id='user-name']"));
            TestSetup.HighlightElement(TestSetup.driver, usernameInput);
            usernameInput.SendKeys("problem_user");
            System.Threading.Thread.Sleep(1000);

            IWebElement passwordInput = TestSetup.driver.FindElement(By.XPath("//div/input[@id='password']"));
            TestSetup.HighlightElement(TestSetup.driver, passwordInput);
            passwordInput.SendKeys("secret_sauce");
            System.Threading.Thread.Sleep(1000);

            IWebElement loginBtn = TestSetup.driver.FindElement(By.XPath("//div//input[@id='login-button']"));
            TestSetup.HighlightElement(TestSetup.driver, loginBtn);
            loginBtn.Click();
            System.Threading.Thread.Sleep(5000);

        }

    }
}