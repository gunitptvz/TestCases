using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using RelevantCodes.ExtentReports;

namespace Test_Project_Demo
{
    public class ExtentManager
    {
        private static ExtentReports extent;

        public static ExtentReports GetInstance()
        {
            if(extent == null)
            {
                extent = new ExtentReports("D:\\Загрузки\\report.html");
                extent.LoadConfig(Directory.GetCurrentDirectory() + "extent-config.xml");
                extent.AddSystemInfo("Selenium version", "2.53").AddSystemInfo("Environment", "PROD");
            }
            return extent;
        }
    }
}
