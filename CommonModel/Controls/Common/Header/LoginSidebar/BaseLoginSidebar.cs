using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.Common.Header.LoginSidebar
{
    public abstract class BaseLoginSidebar : ControlBase
    {
        protected BaseLoginSidebar(TestSettings testSettings) : base(testSettings)
        {
        }

        public IWebElement Container
        {
            get { return Driver.FindElement(Locators.Container); }
        }

        protected Inputbox EmailInputbox
        {
            get { return new Inputbox(Driver.FindElement(Container, Locators.EmailInputbox)); }
        }

        protected Inputbox PasswordInputbox
        {
            get { return new Inputbox(Driver.FindElement(Container, Locators.PasswordInputbox)); }
        }

        public Button ToggleShowPasswordButton
        {
            get { return new Button(Driver.FindElement(Container, Locators.ToggleShowPasswordButton)); }
        }

        public Link ForgottenPasswordLink
        {
            get { return new Link(Driver.FindElement(Container, Locators.ForgottenPasswordLink)); }
        }

        public Button LoginButton
        {
            get { return new Button(Driver.FindElement(Container, Locators.LoginButton)); }
        }

        public Link RegisterLink
        {
            get { return new Link(Driver.FindElement(Container, Locators.RegisterLink)); }
        }

        public Button DismissSidebarButton
        {
            get { return new Button(Driver.FindElement(Container, Locators.DismissSidebarButton)); }
        }

        public IWebElement IncorrectDetailsMessage
        {
            get { return Driver.FindElement(Container, Locators.IncorrectDetailsMessage); }
        }

        public bool Expanded
        {
            get { return Driver.ElementDisplayed(Locators.Container); }
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
        public class Locators
        {
            public static readonly By Container = By.ClassName("signin-wrapper panel-equalize");
            public static readonly By EmailInputbox = By.CssSelector("[data-at='txt-signin-username']");
            public static readonly By PasswordInputbox = By.CssSelector("[data-at='txt-signin-password']");
            public static readonly By ToggleShowPasswordButton = By.CssSelector("[role='button']");
            public static readonly By ForgottenPasswordLink = By.CssSelector("[data-at='lnk-signin-forgotten-password']");
            public static readonly By LoginButton = By.CssSelector("[data-at='btn-signin']");
            public static readonly By RegisterLink = By.CssSelector("[data-at='lnk-signin-register']");
            public static readonly By DismissSidebarButton = By.CssSelector("[data-at='lnk-signin-close']");
            public static readonly By IncorrectDetailsMessage = By.ClassName("signin-error-holder message-alerts message-alert");
        }
    }
}
