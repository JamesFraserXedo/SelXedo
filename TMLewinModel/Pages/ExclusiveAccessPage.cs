using System.Linq;
using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace TMLewinModel.Pages
{
    public class ExclusiveAccessPage : PageBase
    {
        public ExclusiveAccessPage(TestSettings testSettings) : base(testSettings)
        {

        }

        public override bool IsLoaded()
        {
            return Driver.ElementDisplayed(Locators.PasswordInputbox);
        }

        public IWebElement Container
        {
            get { return Driver.FindElement(Locators.Container); }
        }

        protected Inputbox PasswordInputbox
        {
            get { return new Inputbox(Driver.FindElement(Container, Locators.PasswordInputbox)); }
        }

        public IWebElement SubmitPasswordButton
        {
            get { return Driver.FindElement(Container, Locators.SubmitPasswordButton); }
        }

        public bool OnPage
        {
            get { return Driver.FindElements(Locators.Container).Any(); }
        }

        public void ClearPasswordInputbox()
        {
            PasswordInputbox.Clear();
        }

        public void Submit()
        {
            SubmitPasswordButton.Click();
        }

        public string Password
        {
            get { return PasswordInputbox.Text; }
            set { PasswordInputbox.SendKeys(value); }
        }

        public class Locators
        {
            public static readonly By Container = By.CssSelector("[class='password-page-section']");
            public static readonly By PasswordInputbox = By.Id("Password");
            public static readonly By SubmitPasswordButton = By.CssSelector("[data-at='btn-submit-password']");
        }
    }
}
