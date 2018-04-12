using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using RelevantCodes.ExtentReports;

namespace Nuint
{
    class Detail_Enter
    {
        public ExtentTest test;
        public IWebDriver driver;

        public Detail_Enter(IWebDriver driver, ExtentTest test)
        {
            this.test = test;
            this.driver = driver;
        }

        public void Details()
        {
            //Enter Route number
            driver.FindElement(By.Id("routenum")).SendKeys("123123123");
            //Enter Account number
            driver.FindElement(By.Id("acctnum")).SendKeys("123456789");
            //Enter Check number
            driver.FindElement(By.Id("checknum")).SendKeys("1001");
            //Enter number
            driver.FindElement(By.Id("micrline")).SendKeys("123456789123123123");
            //Enter Email Address
            driver.FindElement(By.Id("txtEmail")).SendKeys("houston@texas.com");
            //Enter Phone number
            driver.FindElement(By.Id("txtContactPhone")).SendKeys("713-555-1212");
                test.Log(LogStatus.Pass, "Enter all the details");
            driver.FindElement(By.Id("NextButtonTab1")).Click();
            //Enter customer account number  
            driver.FindElement(By.Id("pline1")).SendKeys("John Doe");
            //Enter customer address
            driver.FindElement(By.Id("pline3")).SendKeys("10391 Laureate Drive");
            //Enter city
            driver.FindElement(By.Id("city")).SendKeys("San Antonio");
            //Enter state
            driver.FindElement(By.Id("states")).Click();
            SelectElement dropdown = new SelectElement(driver.FindElement(By.Id("states")));
            dropdown.SelectByText("TX");
            //Enter zipcode
            driver.FindElement(By.Id("zip")).SendKeys("78249");
            //Enter name of bank
            driver.FindElement(By.Id("bankinfo1")).SendKeys("Key Bank");
                test.Log(LogStatus.Pass, "Enter all the personal details");
            //Enter next button
            driver.FindElement(By.Id("NextButtonTab2")).Click();
        }
    }
}
