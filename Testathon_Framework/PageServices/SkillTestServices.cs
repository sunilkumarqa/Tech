using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Testathon_Framework.PageElements;



namespace Testathon_Framework.PageServices
{
    public class SkillTestServices
    {
      
       LoginPageElements loginElements = new LoginPageElements();
       CommonPageServices commonPageServices = new CommonPageServices();
       LoginPageServices loginServices = new LoginPageServices();
       SkillTestElements skillTestElements = new SkillTestElements();
       public void SkillTest(IWebDriver driver)
       {
           Actions act = new Actions(driver);
           act.MoveToElement(skillTestElements.linkCompete(driver)).ClickAndHold();
           skillTestElements.linkskillTest(driver).Click();
       }

    }
}
