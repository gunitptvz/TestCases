using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Drawing.Imaging;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using RelevantCodes.ExtentReports;

namespace Test_Project_Demo
{
    public class BaseTest
    {
        public ExtentReports extent = ExtentManager.GetInstance();

        public static void TakeScreenshot(string imagename, IWebDriver driver)
        {
            ITakesScreenshot screenshotdriver = driver as ITakesScreenshot;
            Screenshot screenshot = screenshotdriver.GetScreenshot();
            screenshot.SaveAsFile("D:\\Загрузки\\" + imagename + ".gif", ScreenshotImageFormat.Gif);
        }
    }
}
