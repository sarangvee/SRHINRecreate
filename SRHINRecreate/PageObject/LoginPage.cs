using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SRHINRecreate.PageObject
{
    internal class LoginPage
    {
        private readonly IWebDriver _driver;
        public LoginPage(IWebDriver driver) 
        {
            _driver = driver;
        }

        private IWebElement Username => _driver.FindElement(By.Id(":r0:"));
        private IWebElement Password => _driver.FindElement(By.Id(":r1:"));
        private IWebElement LoginButtonOnHomePage => _driver.FindElement(By.XPath("//button[normalize-space()='Login']"));
        private IWebElement LoginText => _driver.FindElement(By.XPath("//h5[contains(text(),'Login')]"));
        public void LoadUrl(string url)

        {
            
            _driver.Manage().Window.Maximize();
            _driver.Navigate().GoToUrl(url);
        }

        public void EnterCredentials(string username, string password)
        {
            Username.SendKeys(username);
            Password.SendKeys(password);
        }

        public void ClickLoginButtonOnHomePage()
        {
            LoginButtonOnHomePage.Click();
            Thread.Sleep(2000); // Wait for 2 seconds to allow the page to load
        }

        public string LoginHeder()
        {
           return LoginText.Text;
        }

    }
}
