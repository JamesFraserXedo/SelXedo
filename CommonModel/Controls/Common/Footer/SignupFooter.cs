using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.Common.Footer
{
    public abstract class SignupFooter : BaseFooter
    {
        protected SignupFooter(TestSettings testSettings) : base(testSettings)
        {
        }

        protected Inputbox SignUpEmailInputbox
        {
            get { return new Inputbox(Driver.FindElement(Container, Locators.SignUpEmailInputbox)); }
        }

        public Button SignUpSubmitButton
        {
            get { return new Button(Driver.FindElement(Container, Locators.SignUpSubmitButton)); }
        }

        public string SignUpEmail
        {
            get { return SignUpEmailInputbox.Text; }
            set { SignUpEmailInputbox.SendKeys(value); }
        }

        public new class Locators : BaseFooter.Locators
        {
            public static readonly By SignUpEmailInputbox = By.CssSelector("[data-at='txt-footer-mailing']");
            public static readonly By SignUpSubmitButton = By.CssSelector("[data-at='btn-footer-mailing']");
        }
    }
}
