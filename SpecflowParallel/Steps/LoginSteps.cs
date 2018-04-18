using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using OpenQA.Selenium.Firefox;

namespace SpecflowParallel.Steps
{
    [Binding]
     public class LoginSteps
    {
        private readonly IWebDriver _driver;

        public LoginSteps(IWebDriver driver)
        {
            _driver = driver;
        }
       
        [Given(@"I navigate to application")]
        public void GivenINavigateToApplication()
        {
            _driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");
        }

        [Given(@"I enter username and password")]
        public void GivenIEnterUsernameAndPassword(Table table)
        {
            dynamic loginDetails = table.CreateDynamicInstance();

            _driver.FindElement(By.Name("UserName")).SendKeys((string)loginDetails.Username);
            _driver.FindElement(By.Name("Password")).SendKeys((string)loginDetails.Password);
        }

        [Given(@"I click login")]
        public void GivenIClickLogin()
        {
            _driver.FindElement(By.Name("Login")).Submit();
        }

        [Then(@"I should see the user logined to the page")]
        public void ThenIShouldSeeTheUserLoginedToThePage()
        {
           var el= _driver.FindElement(By.XPath("//p[contains(test(),'This is a demo website, which act as a mock site for trying out different automation tools'))]"));
            Assert.Multiple(() =>
            {
                Assert.That(el.Text, Is.Null, "Header text found");
                Assert.That(el.Text, Is.Not.Null, "Header text found");
            });
        }
    }
}
