using System;
using System.Collections;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumCSharpTutorials
{
    [TestFixture]
    public class SeleniumCSharpTutorial04
    {
        [Test]
        [Author("Maciej Dunal", "maciejdunal@gmail.com")]
        [Description("Facebook login Verify")]
        [TestCaseSource("DataDrivenTesting")]
        public void Test1(String urlName)
        {
            IWebDriver driver = null;
            try
            {
                driver = new ChromeDriver(); 
                driver.Manage().Window.Maximize();
                /*driver.Url = "https://www.facebok.com/";*/
                driver.Url = urlName;

/*                IWebElement acceptCookies = driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div/div/div/div/div[3]/button[2]"));
                acceptCookies.Click();*/

/*                IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='abcd']"));*/
                IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
                emailTextField.SendKeys("Selenium C#");
                driver.Quit();
            }
            catch (Exception e)
            {
                ITakesScreenshot ts = driver as ITakesScreenshot;
                Screenshot screenshot = ts.GetScreenshot();
                screenshot.SaveAsFile("C:\\Users\\MD\\source\\repos\\SeleniumCSharp\\SeleniumCSharpTutorials\\Screenshots\\Screenshot1.jpeg", ScreenshotImageFormat.Jpeg); ;
                Console.WriteLine(e.StackTrace);
                throw;
            }
            finally
            {
                if(driver != null)
                {
                    driver.Quit();
                }

            }
;
        }

        static IList DataDrivenTesting()
        {
            ArrayList list = new ArrayList();
            list.Add("https://facebook.com/");
/*          list.Add("https://youtube.com/");
            list.Add("https://gmail.com/");*/

            return list;
        }

/*      [Test]
        [Author("Maciej Dunal", "maciejdunal@gmail.com")]
        [Description("Facebook login Verify")]
        public void Test2()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.facebok.com/";

            IWebElement acceptCookies = driver.FindElement(By.XPath("/html/body/div[3]/div[2]/div/div/div/div/div[3]/button[2]"));
            acceptCookies.Click();

            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
            driver.Quit();
        }*/
    }
}
