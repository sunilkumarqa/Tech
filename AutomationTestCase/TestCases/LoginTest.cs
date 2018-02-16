using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Testathon_Framework.TestScenarios;
using Testathon_Framework.PageServices;
using System.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationTestCase.TestCases
{
    /// <summary>
    /// Summary description for LoginTest
    /// </summary>
    [TestClass]
    public class LoginTest
    {
        public static IWebDriver driver = new ChromeDriver();
        LoginScenarios loginScenarios = new LoginScenarios();
        InvalidLoginScenarios invalidLoginScenarios = new InvalidLoginScenarios();
        CommonPageServices commonPageServices = new CommonPageServices();
     
        []
        public void TestFixtureSetupSteps()
        {

        }


        [TestMethod]
        public void ValidLogin()
        {
         loginScenarios.Execute(driver, ConfigurationManager.AppSettings["UserName"], ConfigurationManager.AppSettings["PassWord"], "param3", "param4");
                    
        }
        [TestMethod]
        public void validUserInvalidPwd()
        {
            invalidLoginScenarios.Execute(driver,"validUserInvalidPwd", ConfigurationManager.AppSettings["UserName"], commonPageServices.EnterRandomText(5), "param4");
        }
        [TestMethod]
        public void InvalidUserValidPwd()
        {
            invalidLoginScenarios.Execute(driver, "InvalidUserValidPwd", commonPageServices.EnterRandomText(5), ConfigurationManager.AppSettings["PassWord"], "param4");
        }
        [TestMethod]
        public void InvalidUserInvalidPwd()
        {
            invalidLoginScenarios.Execute(driver, "InvalidUserInvalidPwd", commonPageServices.EnterRandomText(5), commonPageServices.EnterRandomText(5), "param4");
        }
        [TestMethod]
        public void WithoutUserPwd()
        {
            invalidLoginScenarios.Execute(driver, "WithoutUserPwd", "param2", "param3", "param4");
        }
    }
}
