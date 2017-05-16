using NUnit.Framework;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Project_Demo
{
    [TestFixture]
    [Parallelizable]
    // [Ignore("Skip the test")]
    public class YandexNewsTest : BaseTest
    {
        [Test]
        public void TestNews()
        {
            Console.WriteLine("Test news");

            // selenium code
            // expected, actaul
            // text is present
            // link is present

            // Assert.AreEqual("Good", "Good");

            ExtentTest test = extent.StartTest("Yandex News Test", "News Information");
            test.Log(LogStatus.Info, "News");

            Console.WriteLine("Before assertion error");

            extent.EndTest(test);
            extent.Flush();

            try
            {
                Assert.IsTrue(4 < 3, "Error msg");
                // Assert.IsFalse(3>8, "Error msg");
            }
            catch (Exception e)
            {
                Console.WriteLine("Caught the error");
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("After assertion error");

            // click - assertion - try catch block
        }
    }
}
