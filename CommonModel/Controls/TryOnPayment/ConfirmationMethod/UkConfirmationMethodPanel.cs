using Core.CustomElements;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.TryOnPayment.ConfirmationMethod
{
    public abstract class UkConfirmationMethodPanel : BaseConfirmationMethodPanel
    {
        protected UkConfirmationMethodPanel(TestSettings testSettings) : base(testSettings)
        {
        }

        public Checkbox VisaElectronCheckbox
        {
            get { return new Checkbox(Driver.FindElement(Locators.VisaElectronCheckbox)); }
        }

        protected InputBox CardholderNameInputbox
        {
            get { return new InputBox(Driver.FindElement(Locators.CardholderNameInputbox)); }
        }

        protected InputBox CardNumberInputbox
        {
            get { return new InputBox(Driver.FindElement(Locators.CardNumberInputbox)); }
        }

        protected InputBox ExpiryDateMonthInputbox
        {
            get { return new InputBox(Driver.FindElement(Locators.ExpiryDateMonthInputbox)); }
        }

        protected InputBox ExpiryDateYearInputbox
        {
            get { return new InputBox(Driver.FindElement(Locators.ExpiryDateYearInputbox)); }
        }

        protected InputBox SecurityCodeInputbox
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

        public string ExpiryDateMonth
        {
            get { return ExpiryDateMonthInputbox.Text; }
            set { ExpiryDateMonthInputbox.SendKeys(value); }
        }

        public string ExpiryDateYear
        {
            get { return ExpiryDateYearInputbox.Text; }
            set { ExpiryDateYearInputbox.SendKeys(value); }
        }

        public string SecurityCode
        {
            get { return SecurityCodeInputbox.Text; }
            set { SecurityCodeInputbox.SendKeys(value); }
        }

        public new class Locators : BaseConfirmationMethodPanel.Locators
        {
            public static readonly By VisaElectronCheckbox = By.CssSelector("[data-at='rad-card-type-visa-electron']");
            public static readonly By CardholderNameInputbox = By.Id("bname");
            public static readonly By CardNumberInputbox = By.Id("cardnumber");
            public static readonly By ExpiryDateMonthInputbox = By.Id("expmonth");
            public static readonly By ExpiryDateYearInputbox = By.Id("expyear");
            public static readonly By SecurityCodeInputbox = By.Id("cvm");
        }
    }
}
