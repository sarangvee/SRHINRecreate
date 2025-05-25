using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Claims;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Syntax;
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
        public string GetDashboardHeaderText()
        {
            IWebElement DashboardHeader = _driver.FindElement(By.XPath("//h4[contains(text(),'Student')]"));
            return DashboardHeader.Text;
        }

        public void ClickLogoutButton()
        {
            IWebElement LogoutButton = _driver.FindElement(By.XPath("//*[@id=\"root\"]/div/header/div/button"));
            LogoutButton.Click();
            Thread.Sleep(2000); // Wait for 2 seconds to allow the page to load
        }
        //public void WaitForDashboardToLoad()
        //{
        //    WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
        //    //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//h4[contains(text(),'Student')]")));
        //}

        public string gradeOverview()

        {
            IWebElement Gradeoverview = _driver.FindElement(By.XPath("//div[contains(text(),'Grades Overview')]"));
            return Gradeoverview.Text;
        }

        public string GetDashboardTitle()
        {
            return _driver.Title;
        }

        public string YearlyAttendanceOverview()
        {
            IWebElement YearlyAttendanceOverview = _driver.FindElement(By.XPath("//h6[contains(text(),'Yearly Attendance Overview')]"));
            return YearlyAttendanceOverview.Text;
        }

        public string SchoolClassCalendar()
        {
            IWebElement SchoolClassCalendar = _driver.FindElement(By.XPath("//h6[contains(text(),'School & Class Calendar')]"));
            return SchoolClassCalendar.Text;
        }

        public string PerformanceChart()
        {
            IWebElement PerformanceChart = _driver.FindElement(By.XPath("//h6[contains(text(),'Performance Chart')]"));
            return PerformanceChart.Text;
        }

        public string Events()
        {
            IWebElement Events = _driver.FindElement(By.XPath("//div[contains(text(),'Events')]"));
            return Events.Text;
        }

        public string UpcomingEventsHolidays()
        {
            IWebElement UpcomingEventsHolidays = _driver.FindElement(By.XPath("//div[contains(text(),'Upcoming Events/Holidays')]"));
            return UpcomingEventsHolidays.Text;
        }

        public string UpcomingClassmatesBirthdays()
        {
            IWebElement UpcomingClassmatesBirthdays = _driver.FindElement(By.XPath("//h6[contains(text(),\"Upcoming Classmates' Birthday\")]"));
            return UpcomingClassmatesBirthdays.Text;
        }
    }
}