using System;
using NUnit.Framework;
using Testathon_Framework.TestScenarios;
using Testathon_Framework.PageServices;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AutomationTestcases
{
    [TestFixture]
    public class ApplyingJobTestCases
    {
 
        public static IWebDriver driver = new ChromeDriver();
        CommonPageServices commonPageServices = new CommonPageServices();
        LoginPageServices loginServices = new LoginPageServices();
        ApplyingJobScenarios applyingJobScenarios = new ApplyingJobScenarios();
       [SetUp]
        public void TestFixtureSetupSteps()
        {
            loginServices.Launch_Application(driver);
            loginServices.valid_Login(driver, "sunilsdata1@gmail.com", "sunil123");
        }
        [Test]
       public void applyingJob()
       {
           applyingJobScenarios.Execute(driver, "java", "param2", "param3", "param4");
       }
        [OneTimeTearDown]
        public void Teardown()
        {
            commonPageServices.closeDriver(driver);
        }

    }
}