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
            return Driver.ElementDisplayed(Locators.CompleteRegistrationButton);
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

        public string FirstName
        {
            get { return FirstNameInputbox.Text; }
            set { FirstNameInputbox.SendKeys(value); }
        }

        public string LastName
        {
            get { return LastNameInputbox.Text; }
            set { LastNameInputbox.SendKeys(value); }
        }

        public string Email
        {
            get { return EmailInputbox.Text; }
            set { EmailInputbox.SendKeys(value); }
        }

        public string Password
        {
            get { return PasswordInputbox.Text; }
            set { PasswordInputbox.SendKeys(value); }
        }

        public string PasswordConfirmation
        {
            get { return PasswordConfirmationInputbox.Text; }
            set { PasswordConfirmationInputbox.SendKeys(value); }
        }

        public class Locators
        {
            public static readonly By FirstNameInputbox = By.CssSelector("[data-at='txt-reg-first-name']");
            public static readonly By LastNameInputbox = By.CssSelector("[data-at='txt-reg-surname']");
            public static readonly By EmailInputbox = By.CssSelector("[data-at='txt-reg-email']");
            public static readonly By PasswordInputbox = By.CssSelector("[data-at='txt-reg-password']");
            public static readonly By PasswordConfirmationInputbox = By.CssSelector("[data-at='txt-reg-password-confirm']");
            public static readonly By CompleteRegistrationButton = By.CssSelector("[data-at='btn-complete-registration']");
            public static readonly By InvalidFirstNameLabel = By.CssSelector("[class='invalid'][for='MemberDetails_FirstName']");
            public static readonly By InvalidLastNameLabel = By.CssSelector("[class='invalid'][for='MemberDetails_Surname']");
            public static readonly By InvalidEmailLabel = By.CssSelector("[class='invalid'][for='MemberDetails_Email']");
            public static readonly By InvalidEmailPrintedLabel = By.CssSelector("[data-valmsg-for='MemberDetails.Email']");
            public static readonly By InvalidPasswordPrintedLabel = By.CssSelector("[data-valmsg-for='Password.Password']");
            public static readonly By InvalidPasswordConfirmationPrintedLabel = By.CssSelector("[data-valmsg-for='Password.ConfirmPassword']");
        }
    }
}
