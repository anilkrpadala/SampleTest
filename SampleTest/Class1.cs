using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleTest
{
    [TestFixture]
    public class Class1
    {
        public IWebDriver driver;
        [SetUp]
        public void setup()
        {
            var chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("--start-maximized");
            chromeOptions.AddArguments("--window-size=1920,1080");
            chromeOptions.AddArguments("headless");
        }
        [Test]
        public void DemoReportPass()
        {
            Assert.IsTrue(true);
        }
        [Test]
        public void DemoReportFail()
        {
            Assert.IsTrue(false);

        }
        [TearDown]
        public void TearDown()
        {
            driver.Close();
            driver.Quit();
            driver.Dispose();
        }
    }
}
