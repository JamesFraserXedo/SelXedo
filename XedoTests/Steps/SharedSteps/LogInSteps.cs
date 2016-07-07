using System;
using Core.Contexts;
using TechTalk.SpecFlow;
using XedoModel.Bases;

namespace XedoTests.Steps.SharedSteps
{
    [Binding]
    public class LogInSteps : XedoStepBase
    {
        public LogInSteps(Context context) : base(context)
        {
        }

        [Given(@"I am logged on to the site")]
        public void GivenIAmLoggedOnToTheSite()
        {
            var email = string.Format("selenium_tester_xedo_{0}@notanemail.com", DateTime.Now.ToString("dd_MM_yyyy_hh_mm_ss"));
            var password = "Password";

            CurrentContext.Common.CreatedMemberEmail = email;
            CurrentContext.Common.CreatedMemberPassword = password;

            LoginForm.Expand();
            LoginForm.RegisterLink.Click();
            NewMemberRegistrationPage.FirstNameInputBox.SendKeys("Selenium");
            NewMemberRegistrationPage.LastNameInputBox.SendKeys("Tester");
            NewMemberRegistrationPage.EmailAddressInputBox.SendKeys(email);
            NewMemberRegistrationPage.PasswordInputBox.SendKeys("Password");
            NewMemberRegistrationPage.ConfirmPasswordInputBox.SendKeys("Password");
            NewMemberRegistrationPage.CompleteRegistrationButton.Click();
            //Should automatically redirect to original page
        }
    }
}
