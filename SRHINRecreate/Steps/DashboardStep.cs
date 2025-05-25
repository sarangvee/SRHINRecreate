using System;
using OpenQA.Selenium;
using Reqnroll;
using SRHINRecreate.PageObject;

namespace SRHINRecreate.Steps
{
   [Binding]

    public class DashboardStep
    {
        private readonly IWebDriver? _driver;
        private readonly DashboardPage? _dashboardPage;

        public DashboardStep(IWebDriver driver)
        {
            _driver = driver;
            _dashboardPage = new DashboardPage(_driver);
        }


        [Given("on the Dashboard page")]
        public void GivenOnTheDashboardPage()
        {
            string? getpagetitle = _dashboardPage?.GetDashboardTitle();
            if (getpagetitle == "Parent Portal")
            {
                Console.WriteLine("Test Passed - Dashboard page is displayed.");
            }
            else
            {
                Console.WriteLine("Test Failed - Dashboard page is not displayed.");
            }
        }

        [Then("the Grade Overview section should display below the name section")]
        public void ThenTheGradeOverviewSectionShouldDisplayBelowTheNameSection()
        {
            _dashboardPage?.gradeOverview();
            string? gradeOverviewText = _dashboardPage?.gradeOverview();
            if (gradeOverviewText == "Grades Overview")
            {
                Console.WriteLine("Test Passed - Grade Overview section is displayed below the name section.");
            }
            else
            {
                Console.WriteLine("Test Failed - Grade Overview section is not displayed below the name section.");
            }
        }


        [Then("the Yearly Attendance Overview section should display below the grade overview")]
        public void ThenTheYearlyAttendanceOverviewSectionShouldDisplayBelowTheGradeOverview()
        {
            _dashboardPage?.YearlyAttendanceOverview();
            string? yearlyAttendanceOverviewText = _dashboardPage?.YearlyAttendanceOverview();
            if (yearlyAttendanceOverviewText == "Yearly Attendance Overview")
            {
                Console.WriteLine("Test Passed - Yearly Attendance Overview section is displayed below the grade overview.");
            }
            else
            {
                Console.WriteLine("Test Failed - Yearly Attendance Overview section is not displayed below the grade overview.");
            }
        }

        [Then("the School & Class Calendar section should display below the Attendance overview")]
        public void ThenTheSchoolClassCalendarSectionShouldDisplayBelowTheAttendanceOverview()
        {
            _dashboardPage?.SchoolClassCalendar();
            string? schoolClassCalendarText = _dashboardPage?.SchoolClassCalendar();
            if (schoolClassCalendarText == "School & Class Calendar")
            {
                Console.WriteLine("Test Passed - School & Class Calendar section is displayed below the Attendance overview.");
            }
            else
            {
                Console.WriteLine("Test Failed - School & Class Calendar section is not displayed below the Attendance overview.");
            }
        }

        [Then("the Performance Chart section should display next to name section")]
        public void ThenThePerformanceChartSectionShouldDisplayNextToNameSection()
        {
            _dashboardPage?.PerformanceChart();
            string? performanceChartText = _dashboardPage?.PerformanceChart();
            if (performanceChartText == "Performance Chart")
            {
                Console.WriteLine("Test Passed - Performance Chart section is displayed next to name section.");
            }
            else
            {
                Console.WriteLine("Test Failed - Performance Chart section is not displayed next to name section.");
            }
        }

        [Then("the Events section should display below the Performance chart")]
        public void ThenTheEventsSectionShouldDisplayBelowThePerformanceChart()
        {
            _dashboardPage?.Events();
            string? eventsText = _dashboardPage?.Events();
            if (eventsText == "Events")
            {
                Console.WriteLine("Test Passed - Events section is displayed below the Performance chart.");
            }
            else
            {
                Console.WriteLine("Test Failed - Events section is not displayed below the Performance chart.");
            }
        }

        [Then("the Upcoming Events Holidays section should display below the Events section")]
        public void ThenTheUpcomingEventsHolidaysSectionShouldDisplayBelowTheEventsSection()
        {
            _dashboardPage?.UpcomingEventsHolidays();
            string? upcomingEventsHolidaysText = _dashboardPage?.UpcomingEventsHolidays();
            if (upcomingEventsHolidaysText == "Upcoming Events/Holidays")
            {
                Console.WriteLine("Test Passed - Upcoming Events Holidays section is displayed below the Events section.");
            }
            else
            {
                Console.WriteLine("Test Failed - Upcoming Events Holidays section is not displayed below the Events section.");
            }
        }

        [Then("the Upcoming Classmates Birthdays section should display below the Upcoming Events Holidays section")]
        public void ThenTheUpcomingClassmatesBirthdaysSectionShouldDisplayBelowTheUpcomingEventsHolidaysSection()
        {
            _dashboardPage?.UpcomingClassmatesBirthdays();
            string? upcomingClassmatesBirthdaysText = _dashboardPage?.UpcomingClassmatesBirthdays();
            if (upcomingClassmatesBirthdaysText == "Upcoming Classmates' Birthday")
            {
                Console.WriteLine("Test Passed - Upcoming Classmates Birthdays section is displayed below the Upcoming Events Holidays section.");
            }
            else
            {
                Console.WriteLine("Test Failed - Upcoming Classmates Birthdays section is not displayed below the Upcoming Events Holidays section.");
            }

        }

    }
}
