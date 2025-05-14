using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium.DevTools;// V133.Network;
using SRHINRecreate.PageObject;
using Reqnroll;


namespace SRHINRecreate.StepDefinitions
{
    [Binding]   
    public class Parentportalsteps
    {
        private readonly IWebDriver _driver;
        private readonly LoginPage _loginPage;
        private readonly DashboardPage _dashboardPage;
        private readonly Profilepage _profilePage;
        private readonly CurriculumPage _CurriculumPage;
        private readonly HomeworkPage _homeworkPage;
        private readonly NotificationPage _notificationPage;
        private readonly FeedbackPage _feedbackPage;
        private readonly FeesPage _feesPage;

        public Parentportalsteps(IWebDriver driver)
        {
            _driver = driver;
            _loginPage = new LoginPage(_driver);
            _dashboardPage = new DashboardPage(_driver);
            _profilePage = new Profilepage(_driver);
            _CurriculumPage = new CurriculumPage(_driver);
            _homeworkPage = new HomeworkPage(_driver);
            _notificationPage = new NotificationPage(_driver);
            _feedbackPage = new FeedbackPage(_driver);
            _feesPage = new FeesPage(_driver);
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

        [Given("on clicking the profile icon")]
        public void GivenOnClickingTheProfileIcon()
        {
            _profilePage.ClickProfileIcon();
            Thread.Sleep(2000); // Wait for 2 seconds to allow the page to load
        }

        [Then("Profile header should be displayed")]
        public void ThenProfileHeaderShouldBeDisplayed()
        {
            //_profilePage.GetProfileHeaderText();
            if (_profilePage.GetProfileHeaderText() == "Student Profile")
            {
                Console.WriteLine("Test Passed - Navigate to Profile");
            }
            else
            {
                Console.WriteLine("Test Failed - Not Navigate to Profile");
            }
        }


        [When("I click the Curriculum button")]
        public void WhenIClickTheCurriculumButton()
        {
            _CurriculumPage.ClickCurriculumIcon();
            Thread.Sleep(2000); // Wait for 2 seconds to allow the page to load
        }

        [Then("I should be redirected to the Curriculum page")]
        public void ThenIShouldBeRedirectedToTheCurriculumPage()
        {
            _CurriculumPage.GetCurriculumHeaderText();

            if (_CurriculumPage.GetCurriculumHeaderText() == "Curriculum")
            {
                Console.WriteLine("Test Passed - Navigate to Curriculum");
            }
            else
            {
                Console.WriteLine("Test Failed - Not Navigate to Curriculum");
            }
        }

        [When("I click the Homework button")]
        public void WhenIClickTheHomeworkButton()
        {
            _homeworkPage.ClickHomeworkIcon();
        }

        [Then("I should be redirected to the Homework page")]
        public void ThenIShouldBeRedirectedToTheHomeworkPage()
        {
            _homeworkPage.GetHomeworkHeaderText();

            if (_homeworkPage.GetHomeworkHeaderText() == "Homework")
            {
                Console.WriteLine("Test Passed - Navigate to Homework");
            }
            else
            {
                Console.WriteLine("Test Failed - Not Navigate to Homework");
            }
        }

        [When("I click the Feedback button")]
        public void WhenIClickTheFeedbackButton()
        {
            _feedbackPage.ClickFeedbackIcon();
            Thread.Sleep(2000); // Wait for 2 seconds to allow the page to load
        }

        [Then("I should be redirected to the Feedback page")]
        public void ThenIShouldBeRedirectedToTheFeedbackPage()
        {
           _feedbackPage.GetFeedbackHeaderText();

            if (_feedbackPage.GetFeedbackHeaderText() == "Feedback")
            {
                Console.WriteLine("Test Passed - Navigate to Feedback");
            }
            else
            {
                Console.WriteLine("Test Failed - Not Navigate to Feedback");
            }
        }

        [When("I click the Notification button")]
        public void WhenIClickTheNotificationButton()
        {
            _notificationPage.ClickNotificationIcon();
        }

        [Then("I should be redirected to the Notification page")]
        public void ThenIShouldBeRedirectedToTheNotificationPage()
        {
            _notificationPage.GetNotificationHeaderText();

            if (_notificationPage.GetNotificationHeaderText() == "Notifications")
            {
                Console.WriteLine("Test Passed - Navigate to Notifications");
            }
            else
            {
                Console.WriteLine("Test Failed - Not Navigate to Notifications");
            }
        }

        [When("I click the Fees button")]
        public void WhenIClickTheFeesButton()
        {
            _feesPage.ClickFeesIcon();
        }

        [Then("I should be redirected to the Fees page")]
        public void ThenIShouldBeRedirectedToTheFeesPage()
        {
            _feesPage.GetFeesHeaderText();
        }

        [When("I click the Logout button")]
        public void WhenIClickTheLogoutButton()
        {
            _dashboardPage.ClickLogoutButton();
        }

        [When("I should be redirected to the Login page")]
        public void WhenIShouldBeRedirectedToTheLoginPage()
        {
            _loginPage.LoginHeder();
            if (_loginPage.LoginHeder() == "Login")
            {
                Console.WriteLine("Test Passed - Navigate to Login");
            }
            else
            {
                Console.WriteLine("Test Failed - Not Navigate to Login");
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
