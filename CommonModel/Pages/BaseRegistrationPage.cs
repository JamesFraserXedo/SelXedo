using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Pages
{
    public abstract class BaseRegistrationPage : PageBase
    {
        protected BaseRegistrationPage(TestSettings testSettings) : base(testSettings)
        {
        }

        public override bool IsLoaded()
        {
            return Driver.ElementDisplayed(Locators.EmailInputbox);
        }

        public InputBox FirstNameInputbox
        {
            get { return new InputBox(Driver.FindElement(Locators.FirstNameInputbox)); }
        }

        public InputBox LastNameInputbox
        {
            get { return new InputBox(Driver.FindElement(Locators.LastNameInputbox)); }
        }

        public InputBox EmailInputbox
        {
            get { return new InputBox(Driver.FindElement(Locators.EmailInputbox)); }
        }

        public InputBox PasswordInputbox
        {
            get { return new InputBox(Driver.FindElement(Locators.PasswordInputbox)); }
        }

        public InputBox PasswordConfirmationInputbox
        {
            get { return new InputBox(Driver.FindElement(Locators.PasswordConfirmationInputbox)); }
        }

        public Button CompleteRegistrationButton
        {
            get { return new Button(Driver.FindElement(Locators.CompleteRegistrationButton)); }
        }

        public IWebElement InvalidFirstNameLabel
        {
            get { return Driver.FindElement(Locators.InvalidFirstNameLabel); }
        }

        public IWebElement InvalidLastNameLabel
        {
            get { return Driver.FindElement(Locators.InvalidLastNameLabel); }
        }

        public IWebElement InvalidEmailLabel
        {
            get { return Driver.FindElement(Locators.InvalidEmailLabel); }
        }

        public IWebElement InvalidEmailPrintedLabel
        {
            get { return Driver.FindElement(Locators.InvalidEmailPrintedLabel); }
        }

        public IWebElement InvalidPasswordPrintedLabel
        {
            get { return Driver.FindElement(Locators.InvalidPasswordPrintedLabel); }
        }

        public IWebElement InvalidPasswordConfirmationPrintedLabel
        {
            get { return Driver.FindElement(Locators.InvalidPasswordConfirmationPrintedLabel); }
        }

        public class Locators
        {
            public static By FirstNameInputbox = By.CssSelector("[data-at='txt-reg-first-name']");
            public static By LastNameInputbox = By.CssSelector("[data-at='txt-reg-surname']");
            public static By EmailInputbox = By.CssSelector("[data-at='txt-reg-email']");
            public static By PasswordInputbox = By.CssSelector("[data-at='txt-reg-password']");
            public static By PasswordConfirmationInputbox = By.CssSelector("[data-at='txt-reg-password-confirm']");
            public static By CompleteRegistrationButton = By.CssSelector("[data-at='btn-complete-registration']");

            public static By InvalidFirstNameLabel = By.CssSelector("[class='invalid'][for='MemberDetails_FirstName']");
            public static By InvalidLastNameLabel = By.CssSelector("[class='invalid'][for='MemberDetails_Surname']");
            public static By InvalidEmailLabel = By.CssSelector("[class='invalid'][for='MemberDetails_Email']");
            public static By InvalidEmailPrintedLabel = By.CssSelector("[data-valmsg-for='MemberDetails.Email']");
            public static By InvalidPasswordPrintedLabel = By.CssSelector("[data-valmsg-for='Password.Password']");
            public static By InvalidPasswordConfirmationPrintedLabel = By.CssSelector("[data-valmsg-for='Password.ConfirmPassword']");
        }
    }
}
