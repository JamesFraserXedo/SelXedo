﻿using Core.CustomElements;
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

        public InputBox SignUpEmailInputBox
        {
            get { return new InputBox(Driver.FindElement(Container, Locators.SignUpEmailInputBox)); }
        }

        public Button SignUpSubmitButton
        {
            get { return new Button(Driver.FindElement(Container, Locators.SignUpSubmitButton)); }
        }

        public new class Locators : BaseFooter.Locators
        {
            public static readonly By SignUpEmailInputBox = By.CssSelector("[data-at='txt-footer-mailing']");
            public static readonly By SignUpSubmitButton = By.CssSelector("[data-at='btn-footer-mailing']");
        }
    }
}
