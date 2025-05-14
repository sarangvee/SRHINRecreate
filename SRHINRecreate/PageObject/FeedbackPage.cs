using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SRHINRecreate.PageObject
{
    internal class FeedbackPage
    {
        private readonly IWebDriver _driver;
        public FeedbackPage(IWebDriver driver)
        {
            _driver = driver;
        }
        private IWebElement FeedbackIcon => _driver.FindElement(By.XPath("//a[@href='/feedback']"));

        private IWebElement FeedbackHeader => _driver.FindElement(By.XPath("//h4[contains(text(),'Feedback')]"));
        public void ClickFeedbackIcon()
        {
            FeedbackIcon.Click();
            Thread.Sleep(2000); // Wait for 2 seconds to allow the page to load
        }
        public string GetFeedbackHeaderText()
        {
            return FeedbackHeader.Text;
        }
    }
}
