using System;
using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace TMLewinModel.Pages
{
    public class RegistrationPage : PageBase
    {
        public RegistrationPage(TestSettings testSettings) : base(testSettings)
        {
        }

        public InputBox FirstNameInputBox
        {
            get { return new InputBox(Driver.FindElement(Locators.FirstNameInputBox)); }
        }

        public InputBox LastNameInputBox
        {
            get { return new InputBox(Driver.FindElement(Locators.LastNameInputBox)); }
        }

        public InputBox EmailAddressInputBox
        {
            get { return new InputBox(Driver.FindElement(Locators.EmailAddressInputBox)); }
        }

        public InputBox PasswordInputBox
        {
            get { return new InputBox(Driver.FindElement(Locators.PasswordInputBox)); }
        }

        public InputBox ConfirmPasswordInputBox
        {
            get { return new InputBox(Driver.FindElement(Locators.ConfirmPasswordInputBox)); }
        }

        public IWebElement CompleteRegistrationButton
        {
            get { return Driver.FindElement(Locators.CompleteRegistrationButton); }
        }

        public override bool IsLoaded()
        {
            return Driver.ElementDisplayed(Locators.FirstNameInputBox);
        }

        public override void SetupState()
        {
            throw new NotImplementedException();
        }

        public class Locators
        {
            public static By FirstNameInputBox = By.CssSelector("[data-at='txt-reg-first-name']");
            public static By LastNameInputBox = By.CssSelector("[data-at='txt-reg-surname']");
            public static By EmailAddressInputBox = By.CssSelector("[data-at='txt-reg-email']");
            public static By PasswordInputBox = By.CssSelector("[data-at='txt-reg-password']");
            public static By ConfirmPasswordInputBox = By.CssSelector("[data-at='txt-reg-password-confirm']");

            public static By CompleteRegistrationButton = By.CssSelector("[data-at='btn-complete-registration']");
        }
    }
}
