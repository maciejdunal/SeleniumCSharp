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
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;

namespace SeleniumCSharpTutorials
{
    [TestFixture]
    public class OrderSkipAttribute
    { 
        [Test,Order(2), Category("OrderSkipAttribute")]
        public void TestMethod1()
        {
            Assert.Ignore("Defect 12345");
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://facebook.com/";
            IWebElement acceptCookies = driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div/div/div/div/div[3]/button[2]"));
            acceptCookies.Click();

            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            driver.Close();
        }

        [Test, Order(1), Category("OrderSkipAttribute")]
        public void TestMethod2()
        {

            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://facebook.com/";
            IWebElement acceptCookies = driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div/div/div/div/div[3]/button[2]"));
            acceptCookies.Click();

            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            driver.Close();
        }

        [Test, Order(0), Category("OrderSkipAttribute")]
        public void TestMethod3()
        {

            IWebDriver driver = new InternetExplorerDriver();
            driver.Url = "https://facebook.com/";
            IWebElement acceptCookies = driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div/div/div/div/div[3]/button[2]"));
            acceptCookies.Click();

            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            driver.Close();
        }
    }
}
 