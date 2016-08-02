using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.TryOnPayment.ConfirmationMethod
{
    public abstract class BaseConfirmationMethodPanel : ControlBase
    {
        protected BaseConfirmationMethodPanel(TestSettings testSettings) : base(testSettings)
        {
        }

        public Checkbox VisaCreditCheckbox
        {
            get { return new Checkbox(Driver.FindElement(Locators.VisaCreditCheckbox)); }
        }

        public Checkbox VisaDebitCheckbox
        {
            get { return new Checkbox(Driver.FindElement(Locators.VisaDebitCheckbox)); }
        }

        public Checkbox MasterCardCreditCheckboxBy
        {
            get { return new Checkbox(Driver.FindElement(Locators.MasterCardCreditCheckboxBy)); }
        }

        public Checkbox MasterCardDebitCheckbox
        {
            get { return new Checkbox(Driver.FindElement(Locators.MasterCardDebitCheckbox)); }
        }

        public Button EnterDefaultCreditCardDetailsButton
        {
            get { return new Button(Driver.FindElement(Locators.EnterDefaultCreditCardDetailsButton)); }
        }

        public class Locators
        {
            public static readonly By VisaCreditCheckbox = By.CssSelector("[data-at='rad-card-type-visa']");
            public static readonly By VisaDebitCheckbox = By.CssSelector("[data-at='rad-card-type-visa-debit']");
            public static readonly By MasterCardCreditCheckboxBy = By.CssSelector("[data-at='rad-card-type-mastercard']");
            public static readonly By MasterCardDebitCheckbox = By.CssSelector("[data-at='rad-card-type-mastercard-debit']");
            public static readonly By EnterDefaultCreditCardDetailsButton = By.Id("enter-test-details");

        }
    }
}
