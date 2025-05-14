using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Reqnroll.BoDi;

namespace SRHINRecreate.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        private readonly IObjectContainer _container;
        private IWebDriver? _driver;

        public  Hooks(IObjectContainer container)
        {
            _container = container;
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Window.Maximize();
            _container.RegisterInstanceAs<IWebDriver>(_driver);
        }
        [AfterScenario]
        public void AfterScenario()
        {
            _driver?.Quit();
            _driver?.Dispose();
        }
    }
}
