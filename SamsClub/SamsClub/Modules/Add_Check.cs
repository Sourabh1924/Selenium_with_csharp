using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using System;
using System.Threading;

namespace Nuint
{
    class Add_Check
    {
        public ExtentTest test;
        public IWebDriver driver;

        public Add_Check(IWebDriver driver, ExtentTest test)
        {
            this.test = test;
            this.driver = driver;
        }

        public void Add()
        {
            Thread.Sleep(3000);
            String iframe = driver.FindElement(By.XPath("//iframe[@class='fancybox-iframe']")).GetAttribute("id");
            driver.SwitchTo().Frame(iframe);
            //String Address = driver.FindElement(By.cssSelector("#lblCurrentNotFound")).getText();
            driver.FindElement(By.XPath("//input[@id='rdoSureItsCorrect']")).Click();
            driver.FindElement(By.CssSelector("#lnkNotFoundContinue")).Click();
                test.Log(LogStatus.Pass, "Select the shipping address");
            driver.SwitchTo().DefaultContent();
            Thread.Sleep(2000);
            driver.FindElement(By.CssSelector("#previewbutton1a")).Click();
            driver.FindElement(By.CssSelector("#ckAgree")).Click();
            driver.FindElement(By.CssSelector("a[id='lbApproveButton2a']")).Click();
            Thread.Sleep(2000);
                test.Log(LogStatus.Pass, "Add the check into cart");
            String iframe1 = driver.FindElement(By.XPath("//iframe[@class='fancybox-iframe']")).GetAttribute("id");
            driver.SwitchTo().Frame(iframe1);
            driver.FindElement(By.XPath("//span[contains(text(),'view cart')]")).Click();
            driver.SwitchTo().DefaultContent();

        }
    }
}
