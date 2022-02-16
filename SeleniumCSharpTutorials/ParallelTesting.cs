﻿// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumCSharpTutorials.BaseClass;
using System.Threading;
using OpenQA.Selenium.Support.UI;
using SeleniumCSharpTutorials.Utilities;

namespace SeleniumCSharpTutorials
{
    [TestFixture]
    public class ParallelTesting
    {
        IWebDriver driver;

        [Test, Category("UTATesting"), Category ("Module1")]
        public void TestMethod1()
        {
            var Driver = new BrowserUtility().Init(driver);

            IWebElement acceptCookies = Driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div/div/div/div/div[3]/button[2]"));
            acceptCookies.Click();

            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();

        }

        [Test, Category("UTATesting"), Category("Module1")]
        public void TestMethod2()
        {
            var Driver = new BrowserUtility().Init(driver);

            IWebElement acceptCookies = Driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div/div/div/div/div[3]/button[2]"));
            acceptCookies.Click();

            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();

        }

        [Test, Category("UTATesting"), Category("Module1")]
        public void TestMethod3()
        {
            var Driver = new BrowserUtility().Init(driver);

            IWebElement acceptCookies = Driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div/div/div/div/div[3]/button[2]"));
            acceptCookies.Click();

            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();

        }

        [Test, Category("UTATesting"), Category("Module1")]
        public void TestMethod4()
        {
            var Driver = new BrowserUtility().Init(driver);

            IWebElement acceptCookies = Driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div/div/div/div/div[3]/button[2]"));
            acceptCookies.Click();

            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();

        }

        [Test, Category("UTATesting"), Category("Module1")]
        public void TestMethod5()
        {
            var Driver = new BrowserUtility().Init(driver);

            IWebElement acceptCookies = Driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div/div/div/div/div[3]/button[2]"));
            acceptCookies.Click();

            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();

        }

        [Test, Category("UTATesting"), Category("Module1")]
        public void TestMethod6()
        {
            var Driver = new BrowserUtility().Init(driver);

            IWebElement acceptCookies = Driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div/div/div/div/div[3]/button[2]"));
            acceptCookies.Click();

            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();

        }

        [Test, Category("UTATesting"), Category("Module1")]
        public void TestMethod7()
        {
            var Driver = new BrowserUtility().Init(driver);

            IWebElement acceptCookies = Driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div/div/div/div/div[3]/button[2]"));
            acceptCookies.Click();

            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();

        }

        [Test, Category("UTATesting"), Category("Module1")]
        public void TestMethod8()
        {
            var Driver = new BrowserUtility().Init(driver);

            IWebElement acceptCookies = Driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div/div/div/div/div[3]/button[2]"));
            acceptCookies.Click();

            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();

        }

        [Test, Category("UTATesting"), Category("Module1")]
        public void TestMethod9()
        {
            var Driver = new BrowserUtility().Init(driver);

            IWebElement acceptCookies = Driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div/div/div/div/div[3]/button[2]"));
            acceptCookies.Click();

            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();

        }

        [Test, Category("UTATesting"), Category("Module1")]
        public void TestMethod10()
        {
            var Driver = new BrowserUtility().Init(driver);

            IWebElement acceptCookies = Driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div/div/div/div/div[3]/button[2]"));
            acceptCookies.Click();

            IWebElement emailTextField = Driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            Driver.Close();

        }
    }
}
 