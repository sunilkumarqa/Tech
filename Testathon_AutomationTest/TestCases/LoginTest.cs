using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Testathon_Framework.PageElements;
using OpenQA.Selenium;
using Testathon_Framework.PageServices;

namespace Testathon_AutomationTest
{
    [TestClass]
    public class LoginTest
    {
        public static IWebDriver driver;
        LoginPageServices loginPageServices = new LoginPageServices();
        [TestMethod]
        public void ValidLogin()
        {
            loginPageServices.valid_Login(driver);
        }
    }
}
