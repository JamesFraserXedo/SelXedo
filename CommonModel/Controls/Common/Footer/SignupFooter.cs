using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.Common.Footer
{
    public class SignupFooter : BaseFooter
    {
        public SignupFooter(TestSettings testSettings) : base(testSettings)
        {
        }

        public InputBox SignUpEmailInputBox
        {
            get { return new InputBox(Driver.FindElement(Container, Locators.SignUpEmailInputBox)); }
        }

        public Button SignUpSubmitButton
        {
            get { return new Button(Driver.FindElement(Container, Locators.SignUpSubmitButton)); }
        }

        public class Locators
        {
            public static By SignUpEmailInputBox = By.CssSelector("[data-at='txt-footer-mailing']");
            public static By SignUpSubmitButton = By.CssSelector("[data-at='btn-footer-mailing']");
        }
    }
}
