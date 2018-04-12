using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using System.Drawing.Imaging;
using System;
using System.IO;

namespace Nuint.Libraries
{
    class Utility_libraries
    {
        static string Folder_name = "E:\\Sourabh_C#\\repo\\SamsClub\\SamsClub\\bin\\Release\\TestResult\\"; 

        public static ExtentReports Create_reporter(ExtentReports extent)
        {
            extent = new ExtentReports(Folder_name + "\\Test_report.html", true); 
            return extent;
        }

        public static String TakeScreenShort(IWebDriver driver)
        {          
            string fileName = Folder_name + String.Format(DateTime.Now.ToString() + ".png");
            Screenshot screenShot = ((ITakesScreenshot)driver).GetScreenshot();
            screenShot.SaveAsFile(fileName, ScreenshotImageFormat.Png);
            return fileName;



        }

      

    }
}
