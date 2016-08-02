using System.ComponentModel;
using System.Linq;
using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Pages
{
    public abstract class BaseExclusiveAccessPage : PageBase
    {
        protected BaseExclusiveAccessPage(TestSettings testSettings) : base(testSettings)
        {
        }

        public override bool IsLoaded()
        {
            return Driver.ElementDisplayed(Locators.PasswordInputbox);
        }
        
        protected Inputbox PasswordInputbox
        {
            get { return new Inputbox(Driver.FindElement(Locators.PasswordInputbox)); }
        }

        public Button SubmitPasswordButton
        {
            get { return new Button(Driver.FindElement(Locators.SubmitPasswordButton)); }
        }
        
        public string Password
        {
            get { return PasswordInputbox.Text; }
            set { PasswordInputbox.SendKeys(value); }
        }

        public void Login()
        {
            Password = "atlanta123";
            SubmitPasswordButton.Click();
        }

        public class Locators
        {
            public static readonly By PasswordInputbox = By.Id("Password");
            public static readonly By SubmitPasswordButton = By.CssSelector("[data-at='btn-submit-password']");
        }
    }
}
