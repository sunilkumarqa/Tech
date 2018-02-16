using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testathon_Framework.PageServices
{
   public class CommonPageServices
    {
        public string EnterRandomText(int length)
        {
            /*var varchars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var varRandom = new Random();
            var varResult = new string(Enumerable.Repeat(varchars, i).Select(s => s[varRandom.Next(s.Length)]).ToArray());
            return varResult;*/
            //Define the included characters
            string charSet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Random random = new Random();
            string randomText = new String(Enumerable.Repeat(charSet, length).Select(set => set[random.Next(set.Length)]).ToArray());
            return randomText;

        }

        public string EnterRandomNo()
        {
            Random random = new Random();
            int tal = random.Next(0, 100000000);
            string randomNumber = tal.ToString();
            return randomNumber;
        }
        public void getScreenShot(IWebDriver driver)
        {

            Screenshot image = ((ITakesScreenshot)driver).GetScreenshot();
            //Save the screenshot
            image.SaveAsFile(string.Format("C:\\Users\\105798\\Documents\\Visual Studio 2013\\Projects\\Testathon_Framework\\snapShot\\Screenshot{0}.Png", getcurrentTime() + " "), ScreenshotImageFormat.Png);

        }
        public string getcurrentTime()
        {
            string currentTime = string.Format("{0:yyyy-MM-dd_hh-mm-ss-tt}", DateTime.Now);
            return currentTime;
        }
        public void closeDriver(IWebDriver driver)
        {
            driver.Quit();
        }
    }
}
