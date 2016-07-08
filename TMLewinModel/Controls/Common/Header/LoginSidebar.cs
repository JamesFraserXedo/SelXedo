using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace TMLewinModel.Controls.Common.Header
{
    public class LoginSidebar : ControlBase
    {
        private Header Header;

        public LoginSidebar(TestSettings testSettings) : base(testSettings)
        {
            Header = new Header(testSettings);
        }
        
        public IWebElement Container
        {
            get { return Driver.FindElement(Locators.Container); }
        }

        public IWebElement DismissButton
        {
            get { return Driver.FindElement(Container, Locators.DismissButton); }
        }
        
        public IWebElement LoginBoxMessage
        {
            get { return Driver.FindElement(Container, Locators.LoginBoxMessage); }
        }

        public InputBox EmailInputBox
        {
            get { return new InputBox(Driver.FindElement(Container, Locators.EmailInputBox)); }
        }

        public InputBox PasswordInputBox
        {
            get { return new InputBox(Driver.FindElement(Container, Locators.PasswordInputBox)); }
        }

        public IWebElement ForgottenPasswordLink
        {
            get { return Driver.FindElement(Container, Locators.ForgottenPasswordLink); }
        }

        public IWebElement LoginButton
        {
            get { return Driver.FindElement(Container, Locators.LoginButton); }
        }

        public IWebElement RegisterLink
        {
            get { return Driver.FindElement(Container, Locators.RegisterLink); }
        }

        public bool Expanded
        {
            get { return Driver.ElementDisplayed(Locators.Container); }
        }

        public void Expand()
        {
            if (Expanded)
            {
                return;
            }
            Header.ToggleLoginSidebarButton.Click();
        }

        public void Close()
        {
            if (!Expanded)
            {
                return;
            }
            DismissButton.Click();
        }

        public string LoginBoxMessageText
        {
            get { return LoginBoxMessage.Text; }
        }

        public void ClearEmailInputBox()
        {
            EmailInputBox.Clear();
        }

        public void InputEmail(string email)
        {
            EmailInputBox.Click();
            ClearEmailInputBox();
            EmailInputBox.SendKeys(email);
        }

        public void ClearPasswordInputBox()
        {
            PasswordInputBox.Clear();
        }

        public void InputPassword(string password)
        {
            PasswordInputBox.Click();
            ClearPasswordInputBox();
            PasswordInputBox.SendKeys(password);
        }

        public void Submit()
        {
            LoginButton.Click();
        }

        public void Login(string username, string password)
        {
            EmailInputBox.Input(username);
            PasswordInputBox.Input(password);
            Submit();
        }

        public class Locators
        {
            public static readonly By Container = By.CssSelector("[class='signin-wrapper panel-equalize']");
            public static readonly By DismissButton = By.Id("signin-close-button");
            public static readonly By LoginBoxMessage = By.CssSelector("[class='right-side-nav-header']");
            public static readonly By EmailInputBox = By.Id("login-username");
            public static readonly By PasswordInputBox = By.Id("login-password");
            public static readonly By ForgottenPasswordLink = By.Id("login-forgot-password");
            public static readonly By LoginButton = By.CssSelector("[data-at='btn-signin']");
            public static readonly By RegisterLink = By.CssSelector("[data-at='lnk-signin-register']");
        }
    }
}
