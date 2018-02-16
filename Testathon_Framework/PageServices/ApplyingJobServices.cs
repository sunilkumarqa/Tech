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
    public class ApplyingJobServices
    {
      
       LoginPageElements loginElements = new LoginPageElements();
       CommonPageServices commonPageServices = new CommonPageServices();
       LoginPageServices loginServices = new LoginPageServices();
       ApplyingJobElements applyingJobElements = new ApplyingJobElements();
       public void applyingJob(IWebDriver driver, string searchtext)
       {
           applyingJobElements.linkJob(driver).Click();
           applyingJobElements.SearchJob(driver).SendKeys(searchtext);
           applyingJobElements.button_SearchJob(driver).Click();
       }

    }
}
