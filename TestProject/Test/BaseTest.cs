using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TestProject.Pages;

namespace TestProject.Test
{

    [TestFixture]
    internal class BaseTest
    {
        protected IWebDriver driver;
        protected GooglePage googlePage;
        protected HCHBPage hchBPage;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Config.URL);
            driver.Manage().Window.Maximize();
            googlePage = new GooglePage(driver);
            hchBPage = new HCHBPage(driver);
        }

        [TearDown]
        public void TearDown()
        {
            if (driver != null)
            {
                driver.Quit();
            }
        }
    }
}
