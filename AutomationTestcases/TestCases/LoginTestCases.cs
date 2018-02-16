using System;
using NUnit.Framework;
using Testathon_Framework.TestScenarios;
using Testathon_Framework.PageServices;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationTestcases
{
    [TestFixture]
    public class LoginTestCases
    {

        public static IWebDriver driver = new ChromeDriver();
        LoginScenarios loginScenarios = new LoginScenarios();
        InvalidLoginScenarios invalidLoginScenarios = new InvalidLoginScenarios();
        CommonPageServices commonPageServices = new CommonPageServices();
        LoginPageServices loginServices = new LoginPageServices();
        VerifyLoginErrorMessagesScenario verifyLoginErrorMessagesScenario = new VerifyLoginErrorMessagesScenario();
        [SetUp]
        public void TestFixtureSetupSteps()
        {
            loginServices.Launch_Application(driver);
        }
        [Test]
        public void WithoutUserPwd()
        {
            invalidLoginScenarios.Execute(driver, "WithoutUserPwd", "param2", "param3", "param4");
        }
        [Test, Order(1)]
        public void validUserInvalidPwd()
        {
            invalidLoginScenarios.Execute(driver, "validUserInvalidPwd", "sunilsdata1@gmail.com", commonPageServices.EnterRandomText(5), "param4");
        }
        [Test, Order(2)]
        public void InvalidUserValidPwd()
        {
            invalidLoginScenarios.Execute(driver, "InvalidUserValidPwd", commonPageServices.EnterRandomText(5), "sunil123", "param4");
        }
        [Test, Order(3)]
        public void InvalidUserInvalidPwd()
        {
            invalidLoginScenarios.Execute(driver, "InvalidUserInvalidPwd", commonPageServices.EnterRandomText(5), commonPageServices.EnterRandomText(5), "param4");
        }
        [Test, Order(4)]
        public void NoUservalidPwd()
        {
            invalidLoginScenarios.Execute(driver, "NoUservalidPwd", "param3", commonPageServices.EnterRandomText(5), "param4");
        }
        [Test, Order(5)]
        public void validUsernoPwd()
        {
            invalidLoginScenarios.Execute(driver, "validUsernoPwd", "sunilsdata1@gmail.com", "param3", "param4");
        }
        [Test, Order(6)]
        public void VerifyErrorMsgvalidUsernoPwd()
        {
            verifyLoginErrorMessagesScenario.Execute(driver, "validUsernoPwd", "param2", "param3", "Please enter your password.");
        }
        [Test, Order(7)]
        public void VerifyErrorMsgNoUservalidPwd()
        {
            verifyLoginErrorMessagesScenario.Execute(driver, "NoUservalidPwd", "param2", "param3", "Please enter your username.");
        }
        [Test, Order(8)]
        public void ValidLogin()
        {
            loginScenarios.Execute(driver, "sunilsdata1@gmail.com", "sunil123", "param3", "param4");
        }

        [OneTimeTearDown]
        public void Teardown()
        {
            commonPageServices.closeDriver(driver);
        }

    }
}