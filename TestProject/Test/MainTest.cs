﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject.Pages;
using TestProject.Utils;

namespace TestProject.Test
{
    internal class MainTest: BaseTest
    {
        private User user;
        public MainTest() 
        {
            user = new User()
            {
                FirstName = "Falcao",
                LastName = "Garcia",
                Email = "falcao.garcia@hchb.com",
                Phone = "877-432-3232",
                Role = Role.Executive,
                Company = "Colombia Soccer",
                City = "San Diego",
                State = "LA",
                Census = "0 - 500"
            };
        }
        [Test]
        public void GoogleSearchTest()
        {         
            googlePage.Search("HCHB");

            string firstUrl = googlePage.GetUrlSearchByIndex(0);

            Assert.That(firstUrl, Is.EqualTo(Config.HchbUrl));
            googlePage.GotoHCHBPage();

            string telephone = hchBPage.GetElementHeaderTextByIndex(1);
            string mail = hchBPage.GetElementHeaderTextByIndex(3);

            Assert.That(telephone, Is.EqualTo("866-535-4242"));
            Assert.That(mail, Is.EqualTo("info@hchb.com"));

            hchBPage.RequestADemo();
            string currentUrl = hchBPage.GetCurrentUrl();

            Assert.That(currentUrl, Is.EqualTo("https://hchb.com/request-demo/"));

            hchBPage.FillForm(user);

            hchBPage.Submit();

            string messageError = hchBPage.GetMessageErrorText();
            string servicesOfferedMessageError = hchBPage.GetServicesOfferedErrorText();
            string captchaMessageError = hchBPage.GetCaptchaErrorText();

            Assert.That(messageError, Is.EqualTo("Please correct the errors below:"));
            Assert.That(servicesOfferedMessageError, Is.EqualTo("This field is required"));
            Assert.That(captchaMessageError, Is.EqualTo("Invalid CAPTCHA"));
        }
    }
}