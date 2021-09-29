using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProjectCoderByte
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {   

        }

        [Test]
        public void Test1()
        {
            //Browser driver
            IWebDriver webDriver = new ChromeDriver(@"C:\web\chromedriver_win32");
            //Navigate to site
            webDriver.Navigate().GoToUrl("http://www.crawco.co.uk");
            //Confirm FacebookPageLink
            string lnkfacebook = webDriver.FindElement(By.TagName("a")).GetAttribute("href^='https://www.facebook.com/crawfordandco'");
        }
        
    }
}