using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;
using XedoModel.Controls.QuickTryOn;

namespace XedoModel.Controls.PaymentConfirmation
{
    class PaymentForm : ControlBase
    {
        public PaymentForm(TestSettings testSettings) : base(testSettings)
        {
        }

        public IWebElement Container
        {
            get { return Driver.FindElement(ColourSelect.Locators.Container); }
        }

        public CreditCardDetailsForm CreditCardDetailsForm
        {
            get { return new CreditCardDetailsForm(TestSettings, Driver.FindElement(Container, Locators.CreditCardDetailsForm)); }
        }

        public BillingAddressForm BillingAddressForm
        {
            get { return new BillingAddressForm(TestSettings, Driver.FindElement(Container, Locators.BillingAddressForm)); }
        }

        public PaymentSummary PaymentSummary
        {
            get { return new PaymentSummary(TestSettings, Driver.FindElement(Container, Locators.PaymentSummary)); }
        }

        public class Locators
        {
            public static readonly By Container = By.XPath(".//*[@id='nab-form']//div[@class='container']");
            public static readonly By CreditCardDetailsForm = By.XPath("//div[@class='form-default-holder'][1]");
            public static readonly By BillingAddressForm = By.XPath("//div[@class='form-default-holder'][2]");
            public static readonly By PaymentSummary = By.XPath("//div[@class='form-default-holder'][3]");
        }
    }
}
