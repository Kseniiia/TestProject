using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProject2
{
    public class Tests
    {
        IWebElement element;
        WebDriver driver = new ChromeDriver();
        string url = "https://github.com/nunit/nunit-console/releases/tag/3.13";

        [SetUp]
        public void Setup()
        {
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