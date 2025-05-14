using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SRHINRecreate.PageObject
{
    internal class NotificationPage
    {
        private readonly IWebDriver _driver;
        public NotificationPage(IWebDriver driver)
        {
            _driver = driver;
        }
        private IWebElement NotificationIcon => _driver.FindElement(By.XPath("//a[@href='/notifications']"));
        private IWebElement NotificationHeader => _driver.FindElement(By.XPath("//h4[contains(text(),'Notifications')]"));
        public void ClickNotificationIcon()
        {
            NotificationIcon.Click();
            Thread.Sleep(2000); // Wait for 2 seconds to allow the page to load
        }

        public string GetNotificationHeaderText()
        {
            return NotificationHeader.Text;
        }
    }
}
