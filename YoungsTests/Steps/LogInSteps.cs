using System;
using Core.Contexts;
using Core.Model.SupportTools;
using NUnit.Framework;
using TechTalk.SpecFlow;
using YoungsModel.Bases;
using YoungsModel.Controls.Common.Header;

namespace YoungsTests.Steps
{
    [Binding]
    public class LogInSteps : YoungsStepBase
    {
        public LogInSteps(Context context) : base(context)
        {
        }

        [Given(@"I am logged in")]
        [Given(@"I am logged on to the site")]
        public void GivenIAmLoggedOnToTheSite()
        {
            var email = string.Format("selenium_tester_xedo_{0}@notanemail.com", DateTime.Now.ToString("dd_MM_yyyy_hh_mm_ss"));
            var password = "Password";

            CurrentContext.Common.CreatedMemberEmail = email;
            CurrentContext.Common.CreatedMemberPassword = password;

            Header.SignInButton.Click();
            LoginSidebar.RegisterLink.Click();
            RegistrationPage.FirstName = "Selenium";
            RegistrationPage.LastName = "Tester";
            RegistrationPage.Email = email;
            RegistrationPage.Password = "Password";
            RegistrationPage.PasswordConfirmation = "Password";
            RegistrationPage.CompleteRegistrationButton.Click();
            //Should automatically redirect to original page
        }

        [When(@"I attempt to sign into the via the sidebar with username ""(.*)"" and password ""(.*)""")]
        public void WhenIAttemptToSignIntoTheViaTheSidebarWithUsernameAndPassword(string username, string password)
        {
            Header.SignInButton.Click();

            LoginSidebar.Email = username;
            LoginSidebar.Password = password;
            LoginSidebar.LoginButton.Click();
        }

        [Then(@"I should be logged in")]
        public void ThenIShouldBeLoggedIn()
        {
            Assert.IsTrue(Header.FavouritesLink.Displayed);
            Assert.IsTrue(Header.OrdersLink.Displayed);
        }

        [Then(@"I should be not logged in")]
        public void ThenIShouldBeNotLoggedIn()
        {
            Assert.IsFalse(Driver.ElementDisplayed(Header.Locators.FavouritesLink));
            Assert.IsFalse(Driver.ElementDisplayed(Header.Locators.OrdersLink));
        }

    }
}
