using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;


namespace TestProject.Pages
{
    internal class BasePage
    {
        protected readonly IWebDriver driver;
        private readonly WebDriverWait wait;
        public BasePage(IWebDriver driver) 
        {
            this.driver = driver;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(Config.MaximumWaitTime));
        }

        public IWebElement WaitForElementToBeVisible(By locator)
        {
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(locator));
        }

        public void NavigateTo(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public string GetCurrentUrl()
        {
            return driver.Url;
        }

        protected List<IWebElement> GetElements(By locator)
        {
            return new List<IWebElement>(driver.FindElements(locator));
        }

        public void Click(By locator)
        {
            WaitForElementToBeVisible(locator);
            driver.FindElement(locator).Click();
        }

        protected string GetText(By locator)
        {
            WaitForElementToBeVisible(locator);
            return driver.FindElement(locator).Text;
        }

        protected void InsertText(By locator, string text)
        {
            WaitForElementToBeVisible(locator);
            driver.FindElement(locator).SendKeys(text);
        }

        protected void SelectElement(By locator, string text)
        {
            IWebElement selectStateElement = driver.FindElement(locator);
            SelectElement select = new SelectElement(selectStateElement);
            select.SelectByText(text);
        }
    }
}
