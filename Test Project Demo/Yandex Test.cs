using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Project_Demo
{
    [TestFixture]
    [Parallelizable]
    public class YandexTest
    {
        [Test]
        public void TestRecieveMail()
        {
            // Selenium code.
            Console.WriteLine("Testing receiving emails");
        }

        [Test]
        public void TestSendMail()
        {
            // Selenium code.
            Console.WriteLine("Testing sending emails");
        }

        [SetUp] // Before executing every test case.
        public void OpenBrowser()
        {
            Console.WriteLine("Opening browser");
        }

        [TearDown] // After executing every test case.
        public void CloseBrowser()
        {
            Console.WriteLine("Closing browser");
        }
    }
}
