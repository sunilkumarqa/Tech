using System;
using NUnit.Framework;
using Testathon_Framework.TestScenarios;
using Testathon_Framework.PageServices;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationTestcases
{
    [TestFixture]
    public class SkillTestCases
    {

        public static IWebDriver driver = new ChromeDriver();
        CommonPageServices commonPageServices = new CommonPageServices();
        LoginPageServices loginServices = new LoginPageServices();
        SkillTestScenarios skillTestScenarios = new SkillTestScenarios();
        [SetUp]
        public void TestFixtureSetupSteps()
        {
            loginServices.Launch_Application(driver);
            loginServices.valid_Login(driver, "sunilsdata1@gmail.com", "sunil123");
        }
        [Test]
        public void skillTest()
        {
            skillTestScenarios.Execute(driver, "param1", "param2", "param3", "param4");
        }
        [OneTimeTearDown]
        public void Teardown()
        {
            commonPageServices.closeDriver(driver);
        }

    }
}