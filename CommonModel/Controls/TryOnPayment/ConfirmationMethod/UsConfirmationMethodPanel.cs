﻿using Core.CustomElements;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.TryOnPayment.ConfirmationMethod
{
    public abstract class UsConfirmationMethodPanel : BaseConfirmationMethodPanel
    {
        protected UsConfirmationMethodPanel(TestSettings testSettings) : base(testSettings)
        {
        }

        public Checkbox AmexCreditCheckbox
        {
            get { return new Checkbox(Driver.FindElement(Locators.AmexCreditCheckbox)); }
        }

        public InputBox CardholderNameInputbox
        {
            get { return new InputBox(Driver.FindElement(Locators.CardholderNameInputbox)); }
        }

        public InputBox CardNumberInputbox
        {
            get { return new InputBox(Driver.FindElement(Locators.CardNumberInputbox)); }
        }

        public InputBox ExpiryDateInputbox
        {
            get { return new InputBox(Driver.FindElement(Locators.ExpiryDateInputbox)); }
        }

        public InputBox SecurityCodeInputbox
        {
            get { return new InputBox(Driver.FindElement(Locators.SecurityCodeInputbox)); }
        }

        public string CardholderName
        {
            get { return CardholderNameInputbox.Text; }
            set { CardholderNameInputbox.SendKeys(value); }
        }

        public string CardNumber
        {
            get { return CardNumberInputbox.Text; }
            set { CardNumberInputbox.SendKeys(value); }
        }

        public string ExpiryDate
        {
            get { return ExpiryDateInputbox.Text; }
            set { ExpiryDateInputbox.SendKeys(value); }
        }

        public string SecurityCode
        {
            get { return SecurityCodeInputbox.Text; }
            set { SecurityCodeInputbox.SendKeys(value); }
        }

        public new class Locators : BaseConfirmationMethodPanel.Locators
        {
            public static readonly By AmexCreditCheckbox = By.CssSelector("[data-at='rad-card-type-amex-debit']");
            public static readonly By CardholderNameInputbox = By.CssSelector("[data-at='txt-cardholder-name']");
            public static readonly By CardNumberInputbox = By.CssSelector("[data-at='txt-card-number']");
            public static readonly By ExpiryDateInputbox = By.CssSelector("[data-at='txt-expiry-date']");
            public static readonly By SecurityCodeInputbox = By.CssSelector("[data-at='txt-security-code']");
        }
    }
}
