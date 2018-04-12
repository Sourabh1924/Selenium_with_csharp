using Nuint;
using Nuint.Libraries;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Extensions;
using RelevantCodes.ExtentReports;
using System;
using System.IO;

namespace SamsClub
{

        [TestFixture]
        public class Class1
        {
            public IWebDriver driver;
            public ExtentTest test;
            public ExtentReports extent;
            

                [Test, Order(1)]
                public void SetUp()
                {
                    driver = new ChromeDriver();
                    extent = Utility_libraries.Create_reporter(extent);
                    test = extent.StartTest("SetUp");
                    test.Log(LogStatus.Pass, "Setup create successfully");

                }

                [Test, Order(2)]
                public void Launch()
                {
                    test = extent.StartTest("Launch");
                    driver.Navigate().GoToUrl("http://www.newtours.demoaut.com/");
                    driver.Manage().Window.Maximize();
                    try
                    {
                        if (driver.Url == "http://www.newtours.demoaut.com/")
                        {
                            test.Log(LogStatus.Pass, "Browser launch successfully");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.StackTrace);
                        test.Log(LogStatus.Fail, "Browser does not launch successfully");
                    }
                }


                [Test, Order(3)]
                public void Search()
                {
                    test = extent.StartTest("Search");
                    Search Search_obj = new Search(driver, test);
                    Search_obj.Search_check();
                }


                [Test, Order(4)]
                public void Details_Enter()
                {
                    test = extent.StartTest("EnterFlightDetails");
                    Detail_Enter Fdetail_obj = new Detail_Enter(driver, test);
                    Fdetail_obj.Details();
                }


                [Test, Order(5)]
                public void Add_Check()
                {
                    test = extent.StartTest("SelectFlight");
                    Add_Check Check_obj = new Add_Check(driver, test);
                    Check_obj.Add();
                }


                [Test, Order(6)]
                public void Close()
                {
                    test = extent.StartTest("Close");
                    driver.Close();
                    driver.Quit();

                    extent.EndTest(test);
                    extent.Flush();
                }
    }
}



