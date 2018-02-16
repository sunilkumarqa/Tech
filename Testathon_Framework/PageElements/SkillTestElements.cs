using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testathon_Framework.PageElements
{
    public class SkillTestElements
    {
      public IWebElement linkCompete(IWebDriver driver)
       {
           IWebElement Compete = driver.FindElement(By.XPath("//span[@class='menu-text'][text()='Compete']"));
           return Compete;
       }
      public IWebElement linkskillTest(IWebDriver driver)
      {
          IWebElement skilltest = driver.FindElement(By.LinkText("Skill Tests"));
          return skilltest;
      }
     
    }
}
