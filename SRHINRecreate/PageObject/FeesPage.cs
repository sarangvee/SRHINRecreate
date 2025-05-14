using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SRHINRecreate.PageObject
{
    internal class FeesPage
    {
        private readonly IWebDriver _driver;
        public FeesPage(IWebDriver driver)
        {
            _driver = driver;
        }
        private IWebElement FeesIcon => _driver.FindElement(By.XPath("//a[@href='/fees']"));
        private IWebElement FeesHeader => _driver.FindElement(By.XPath("//h4[contains(text(),'Fees')]"));
        public void ClickFeesIcon()
        {
            FeesIcon.Click();
            Thread.Sleep(2000); // Wait for 2 seconds to allow the page to load
        }
        public string GetFeesHeaderText()
        {
            return FeesHeader.Text;
        }
    }
}
