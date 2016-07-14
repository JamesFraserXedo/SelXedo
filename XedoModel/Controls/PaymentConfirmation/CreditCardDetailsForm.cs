using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace XedoModel.Controls.PaymentConfirmation
{
    internal class CreditCardDetailsForm : ControlBase
    {
        private IWebElement _container;

        public CreditCardDetailsForm(TestSettings testSettings, IWebElement container) : base(testSettings)
        {
            _container = container;
        }

        public IWebElement VisaCreditRadioButton
        {
            get { return Driver.FindElement(_container, Locators.VisaCreditRadioButton); }
        }

        public IWebElement VisaDebitRadioButton
        {
            get { return Driver.FindElement(_container, Locators.VisaDebitRadioButton); }
        }

        public IWebElement MastercardCreditRadioButton
        {
            get { return Driver.FindElement(_container, Locators.MastercardCreditRadioButton); }
        }

        public IWebElement MastercardDebitRadioButton
        {
            get { return Driver.FindElement(_container, Locators.MastercardDebitRadioButton); }
        }

        public IWebElement AmexCreditRadioButton
        {
            get { return Driver.FindElement(_container, Locators.AmexCreditRadioButton); }
        }

        public InputBox NameInputBox
        {
            get { return new InputBox(Driver.FindElement(_container, Locators.NameInputBox)); }
        }

        public InputBox CardNumberInputBox
        {
            get { return new InputBox(Driver.FindElement(_container, Locators.CardNumberInputBox)); }
        }

        public InputBox ExpiryDateInputBox
        {
            get { return new InputBox(Driver.FindElement(_container, Locators.ExpiryDateInputBox)); }
        }

        public InputBox SecurityCodeInputBox
        {
            get { return new InputBox(Driver.FindElement(_container, Locators.SecurityCodeInputBox)); }
        }

        public IWebElement DefaultCreditCardDetailsButton
        {
            get { return Driver.FindElement(_container, Locators.DefaultCreditCardDetailsButton); }
        }

        public class Locators
        {
            public static readonly By VisaCreditRadioButton = By.Id("visa");
            public static readonly By VisaDebitRadioButton = By.Id("visa-debit");
            public static readonly By MastercardCreditRadioButton = By.Id("mastercard");
            public static readonly By MastercardDebitRadioButton = By.Id("mastercard-debit");
            public static readonly By AmexCreditRadioButton = By.Id("amex-debit");

            public static readonly By NameInputBox = By.Id("CardHolderName");
            public static readonly By CardNumberInputBox = By.Id("CardNumber");
            public static readonly By ExpiryDateInputBox = By.Id("ExpiryDate");
            public static readonly By SecurityCodeInputBox = By.Id("SecurityCode");

            public static readonly By DefaultCreditCardDetailsButton = By.Id("enter-test-details");
        }
    }
}
