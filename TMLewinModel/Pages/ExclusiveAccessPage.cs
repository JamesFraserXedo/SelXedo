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
            return Driver.ElementDisplayed(Locators.PasswordInputBox);
        }

        public IWebElement Container
        {
            get { return Driver.FindElement(Locators.Container); }
        }

        public InputBox PasswordInputBox
        {
            get { return new InputBox(Driver.FindElement(Container, Locators.PasswordInputBox)); }
        }

        public IWebElement SubmitPasswordButton
        {
            get { return Driver.FindElement(Container, Locators.SubmitPasswordButton); }
        }

        public bool OnPage
        {
            get { return Driver.FindElements(Locators.Container).Any(); }
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
            SubmitPasswordButton.Click();
        }

        public class Locators
        {
            public static readonly By Container = By.CssSelector("[class='password-page-section']");
            public static readonly By PasswordInputBox = By.Id("Password");
            public static readonly By SubmitPasswordButton = By.CssSelector("[data-at='btn-submit-password']");
        }
    }
}
