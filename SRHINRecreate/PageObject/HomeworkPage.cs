using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SRHINRecreate.PageObject
{
    internal class HomeworkPage
    {
        private readonly IWebDriver _driver;
        public HomeworkPage(IWebDriver driver)
        {
            _driver = driver;
        }
        private IWebElement HomeworkIcon => _driver.FindElement(By.XPath("//a[@href='/homework']"));
        private IWebElement HomeworkHeader => _driver.FindElement(By.XPath("//h4[contains(text(),'Homework')]"));
        public void ClickHomeworkIcon()
        {
            HomeworkIcon.Click();
            Thread.Sleep(2000); // Wait for 2 seconds to allow the page to load
        }

        public string GetHomeworkHeaderText()
        {
            return HomeworkHeader.Text;
        }

    }
}
