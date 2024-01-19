using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using TestProject.Utils;

namespace TestProject.Pages
{
    internal class HCHBPage : BasePage
    {
        private readonly By headerElements = By.XPath("//div[@class='e-con-inner']/div/div/div/div/ul/li/a/span");
        private readonly By requestADemoBtn = By.XPath("//div[@class='e-con-inner']/div/div/div/div/div/div/a/span/span[text()='Request a Demo']");
        private readonly By headerSection = By.XPath("//div[@data-elementor-type='header']");

        private readonly By iFrameForm = By.ClassName("pardotform");
        private readonly By firstNameText = By.XPath("//label[contains(text(), 'First Name')]/following-sibling::input");
        private readonly By lastNameText = By.XPath("//label[text()='Last Name *']/following-sibling::input");
        private readonly By emailText = By.XPath("//label[text()='Email *']/following-sibling::input");
        private readonly By phoneText = By.XPath("//label[text()='Phone *']/following-sibling::input");
        private readonly By roleSelect = By.Id("74282_206784pi_74282_206784");
        private readonly By companyText = By.XPath("//label[text()='Company *']/following-sibling::input");
        private readonly By cityText = By.XPath("//label[text()='City *']/following-sibling::input");
        private readonly By stateSelect = By.Id("74282_206793pi_74282_206793");
        private readonly By censusSelect = By.Id("74282_206796pi_74282_206796");

        private readonly By submitBtn = By.XPath("//input[@value='Submit']");

        private readonly By errorMessage = By.XPath("//p[@class='errors']");
        private readonly By servicesOfferedMessage = By.XPath("//label[text()='Services Offered *']/ancestor::p//following-sibling::p");
        private readonly By captchaErrorMessage = By.XPath("//div[@class='g-recaptcha']/following-sibling::p[@class='error no-label']");

        public HCHBPage(IWebDriver driver) : base(driver)
        {
        }
        public string GetElementHeaderTextByIndex(int row)
        {
            return GetElements(headerElements).ElementAt(row).Text;
        }

        public void RequestADemo()
        {
            Click(requestADemoBtn);
            WaitForElementToBeVisible(headerSection);
        }

        public void FillForm(User user)
        {
            IWebElement iframeElement = driver.FindElement(iFrameForm);
            driver.SwitchTo().Frame(iframeElement);

            InsertText(firstNameText, user.FirstName);

            InsertText(lastNameText, user.LastName);
            InsertText(emailText, user.Email);
            InsertText(phoneText, user.Phone);

            SelectElement(roleSelect, user.Role.ToString());

            InsertText(companyText, user.Company);
            InsertText(cityText, user.City);

            SelectElement(stateSelect, user.State);
            SelectElement(censusSelect, user.Census);
        }

        public void Submit()
        {
            Click(submitBtn);
        }

        public string GetMessageErrorText()
        {
            return GetText(errorMessage);
        }

        public string GetServicesOfferedErrorText()
        {
            return GetText(servicesOfferedMessage);
        }

        public string GetCaptchaErrorText()
        {
            return GetText(captchaErrorMessage);
        }
    }
}
