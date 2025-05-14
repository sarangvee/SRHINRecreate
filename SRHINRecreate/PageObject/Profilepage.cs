using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SRHINRecreate.PageObject
{
    internal class Profilepage
    {
        private readonly IWebDriver _driver;
        
        public Profilepage(IWebDriver driver)
        {
            _driver = driver;
        }

        private IWebElement ProfileIcon => _driver.FindElement(By.XPath("//a[@href='/profile']"));
        private IWebElement ProfileHeader => _driver.FindElement(By.XPath("//h4[contains(text(),'Profile')]"));

        public void ClickProfileIcon()
        {
            ProfileIcon.Click();
            Thread.Sleep(2000); // Wait for 2 seconds to allow the page to load
        }
        public string GetProfileHeaderText()
        {
            return ProfileHeader.Text;
        }
        //public void WaitForProfileToLoad()
        //{
        //    WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
        //    wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//h4[contains(text(),'Profile')]"))); // Fix: Ensure ExpectedConditions is properly referenced
        //}
    }
}
