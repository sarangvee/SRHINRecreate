using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SRHINRecreate.PageObject
{
    internal class CurriculumPage
    {
        private readonly IWebDriver _driver;

        public CurriculumPage(IWebDriver driver)
        {
            _driver = driver;
        }

        private IWebElement CurriculumIcon => _driver.FindElement(By.XPath("//a[@href='/curriculam']"));

        private IWebElement CurriculumHeader => _driver.FindElement(By.XPath("//h4[contains(text(),'Curriculum')]"));

        public void ClickCurriculumIcon()
        {
            CurriculumIcon.Click();
            Thread.Sleep(2000); // Wait for 2 seconds to allow the page to load
        }

        public string GetCurriculumHeaderText()
        {
            return CurriculumHeader.Text;
        }



    }
}
