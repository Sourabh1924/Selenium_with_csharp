using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using System;
using System.Threading;

namespace Nuint
{
    class Search
    {
        public ExtentTest test;
        public IWebDriver driver;

        public Search(IWebDriver driver, ExtentTest test)
        {
            this.test = test;
            this.driver = driver;
        }

        public void Search_check()
        {
            try
            {
                driver.FindElement(By.XPath("//a[@id='bx-close-inside-439505']")).Click();
                    test.Log(LogStatus.Pass, "Close the popup box");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                    test.Log(LogStatus.Fail, "Fail to close the popup box");
            }
            Thread.Sleep(5000);
            driver.FindElement(By.CssSelector("a[href*='add=n14']")).Click();
            driver.FindElement(By.XPath("//ul[@class='dropdown-menu']/descendant::a[contains(text(),'Basic Checks')]")).Click();
                test.Log(LogStatus.Pass, "Click on Personal check then Basic check");
            driver.FindElement(By.XPath("//p[contains(text(),'Elite Checks')]")).Click();
                test.Log(LogStatus.Pass, "Click on Elite Checks");
            driver.FindElement(By.XPath("//span[contains(text(),'Single Checks')]")).Click();
            driver.FindElement(By.XPath(".//*[@id='ProductOptions_rptrSingles_ctl00_lblOptionTitle']")).Click();
                test.Log(LogStatus.Pass, "Select the check box and click next button");
            driver.FindElement(By.Id("lnkBtnPersonalize")).Click();
        }
    }
}
