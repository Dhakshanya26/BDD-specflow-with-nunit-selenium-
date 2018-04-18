using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using TechTalk.SpecFlow;

namespace SpecflowParallel
{
    public class Hook
    {
        private readonly IObjectContainer _objectContainer;
        private IWebDriver _driver;
        public Hook(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }

        [BeforeScenario(Order = 0)]
        public void Initialize()
        {
            _driver = new FirefoxDriver();
            _objectContainer.RegisterInstanceAs(_driver);
        }

        [AfterScenario(Order = 1)]
        public void CleanUp()
        {
            _driver.Quit();
        }
    }
}
