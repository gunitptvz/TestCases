using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using RelevantCodes.ExtentReports;
using RelevantCodes.ExtentReports.Model;

namespace Test_Project_Demo
{
    [TestFixture]
    public class TestA : BaseTest
    {
        [NUnit.Framework.Test]
        public void TestMethod()
        {
            ExtentTest test = extent.StartTest("Test A", "Sample Description");
            test.Log(LogStatus.Info, "Validating the download link");

            IWebDriver driver = new FirefoxDriver();
            try
            {
                driver.Url = "http://www.seleniumhq.org/";
                driver.Manage().Window.Maximize();
                IWebElement element = driver.FindElement(By.XPath(".//li[@id='menu_downloa']"));
                element.Click();
            }
            catch (Exception e)
            {
                TakeScreenshot("Error Screenshot", driver);
                test.Log(LogStatus.Info, "Screenshot - " + test.AddScreenCapture("D:\\Загрузки\\Error Screenshot.gif"));
                test.Log(LogStatus.Fail, e.Message);

                extent.EndTest(test);
                extent.Flush();

                driver.Quit();
            }
        }
    }
}
