using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V133.Network;
using SRHINRecreate.PageObject;
using Reqnroll;


namespace SRHINRecreate.StepDefinitions
{
    [Binding]   
    public class LoginStepDefination
    {
        private readonly IWebDriver _driver;
        private readonly LoginPage _loginPage;
        private readonly DashboardPage _dashboardPage;

        public LoginStepDefination(IWebDriver driver)
        {
            _driver = new ChromeDriver();
            _loginPage = new LoginPage(_driver);
            _dashboardPage = new DashboardPage(_driver);
        }

        [Given("on loading the url")]
        public void GivenOnLoadingTheUrl()
        {
            _loginPage.LoadUrl("https://parentportaldev-gkd3c2cafzegb3de.centralindia-01.azurewebsites.net/login");
        }

        [When("passing the username and password")]
        public void WhenPassingTheUsernameAndPassword()
        {
            _loginPage.EnterCredentials("sineka003@gmail.com", "saina@123");
        }

        [When("clicking on the login button")]
        public void WhenClickingOnTheLoginButton()
        {
            _loginPage.ClickLoginButtonOnHomePage();
        }

        [Then("Dashboard should be displayed")]
        public void ThenDashboardShouldBeDisplayed()
        {
            _dashboardPage.GetDashboardHeaderText();

            if(_dashboardPage.GetDashboardHeaderText() == "Student Dashboard")
            {
                Console.WriteLine("Test Passed - Navigate to Student Dashboard");
            }
            else
            {
                Console.WriteLine("Test Failed - Not Navigate to Student Dashboard");
            }
        }




        //IWebDriver driver = new ChromeDriver();

        //[Given("on loading the url")]
        //public void GivenOnLoadingTheUrl()
        //{
        //    driver.Manage().Window.Maximize();
        //    driver.Navigate().GoToUrl("https://parentportaldev-gkd3c2cafzegb3de.centralindia-01.azurewebsites.net/");
        //    driver.FindElement(By.XPath("//button[normalize-space()='Login']")).Click();
        //}

        //[When("passing the username and password")]
        //public void WhenPassingTheUsernameAndPassword()
        //{
        //    driver.FindElement(By.Id(":r3:")).SendKeys("sineka003@gmail.com");
        //    driver.FindElement(By.Id(":r4:")).SendKeys("saina@123");
        //}

        //[When("clicking on the login button")]
        //public void WhenClickingOnTheLoginButton()
        //{
        //    driver.FindElement(By.XPath("//button[@type='button']")).Click();
        //}

        //[Then("Dashboard should be displayed")]
        //public void ThenDashboardShouldBeDisplayed()
        //{
        //    Thread.Sleep(2000);
        //    string expectedvalue = "Student Dashboard";
        //    string actualvalue = driver.FindElement(By.XPath("//h4[contains(text(),'Student')]")).Text;

        //    Assert.AreEqual(expectedvalue, actualvalue);

        //    if (expectedvalue == actualvalue)
        //    {
        //        Console.WriteLine("Test Passed - Navigate to Student Dashboard");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Test Failed - Not Navigate to Student Dashboard");
        //    }

        //    driver.Quit();
    }
}
