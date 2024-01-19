﻿using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V118.DOM;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.Pages
{
    internal class GooglePage: BasePage
    {
        private readonly By searchLabel = By.Id("APjFqb");
        private readonly By searchBtn = By.XPath("//div[@class='FPdoLc lJ9FBc']/center/input[@name='btnK']");
        private readonly By urlElement = By.XPath("//cite");

        public GooglePage(IWebDriver driver): base(driver){ }

        public void Search(string searchText)
        {
            var element = WaitForElementToBeVisible(searchLabel);
            element.Clear();
            driver.FindElement(searchLabel).SendKeys(searchText);
            Actions actions = new Actions(driver);
            actions.SendKeys(element, Keys.Tab).Build().Perform();
            Click(searchBtn);
            WaitForElementToBeVisible(urlElement);
        }

        public string GetUrlSearchByIndex(int row)
        {
            return GetElements(urlElement).ElementAt(row).Text;
        }

        public void GotoHCHBPage()
        {
            NavigateTo(Config.HchbUrl);
        }
    }
}
