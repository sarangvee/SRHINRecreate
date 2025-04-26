using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SRHINRecreate.PageObject
{
    internal class DashboardPage
    {
        private readonly IWebDriver _driver;
        public DashboardPage(IWebDriver driver)
        {
            _driver = driver;
        }

        //public object SeleniumExtras { get; private set; }

        private IWebElement DashboardHeader => _driver.FindElement(By.XPath("//h4[contains(text(),'Student')]"));
        public string GetDashboardHeaderText()
        {
            return DashboardHeader.Text;
        }
        //public void WaitForDashboardToLoad()
        //{
        //    WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
        //    //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//h4[contains(text(),'Student')]")));
        //}
    }
}
