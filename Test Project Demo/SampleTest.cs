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
    public class SampleTest
    {
        [Test] // testApp is our Test Case
        public void TestApp()
        {
            Console.WriteLine("Testing app");
        }

        [Test]
        public void TestLogin()
        {
            Console.WriteLine("Login Test");
        }
    }
}
