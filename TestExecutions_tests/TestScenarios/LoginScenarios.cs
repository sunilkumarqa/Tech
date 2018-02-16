using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testathon_AutomationTest;

namespace TestExecutions_tests.TestScenarios
{
   
 public class LoginScenarios
    {
     LoginTest logintest = new LoginTest();
     public void Execute(){
         logintest.ValidLogin();
         logintest.InValidLogin();
     }
    }
}
