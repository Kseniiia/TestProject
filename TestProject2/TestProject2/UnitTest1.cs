using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace TestProject2
{
    public class Tests
    {
        string chromeDriverDirectory = "C:\\TestProject\\TestProject2\\TestProject2\\bin\\Release\\netcoreapp3.1";
        IWebElement element;
        ChromeOptions options = new ChromeOptions();
        ChromeDriver driver;
        //WebDriver driver = new ChromeDriver();

        string url = "https://github.com/nunit/nunit-console/releases/tag/3.13";

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver(chromeDriverDirectory, options, TimeSpan.FromMinutes(3));
            driver.Manage().Timeouts().PageLoad.Add(System.TimeSpan.FromSeconds(30));
            options.AddArgument("no-sandbox");
          
            driver.Navigate().GoToUrl(url);
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual(5,10);
        }

        [Test]
        public void Test3()
        {
            element = driver.FindElement(By.XPath("//*[@id='repo - content - pjax - container']/div/div/div[1]/div[2]/div[1]/h1"));
            Assert.IsNotNull(element);
        }
    }
}