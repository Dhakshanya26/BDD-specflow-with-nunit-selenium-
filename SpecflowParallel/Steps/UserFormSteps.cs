using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace SpecflowParallel.Steps
{
    [Binding]
    public class UserFormSteps
    {
        private readonly IWebDriver _driver;

        public UserFormSteps(IWebDriver driver)
        {
            _driver = driver;
        }
        [Given(@"I start entering user form details")]
        public void GivenIStartEnteringUserFormDetails(Table table)
        {
            Console.WriteLine("start entering user form details");
        }

        [Given(@"I click submit button")]
        public void GivenIClickSubmitButton()
        {
            Console.WriteLine("click submit button");
        }

       
    }
}
