using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace Core.Controls.PaymentConfirmation
{
    class PaymentSummary : ControlBase
    {
        private IWebElement _container;

        public PaymentSummary(TestSettings testSettings, IWebElement container)
            : base(testSettings)
        {
            _container = container;
        }

        public IWebElement CancelButton
        {
            get { return Driver.FindElement(_container, Locators.CancelButton); }
        }

        public IWebElement ConfirmButton
        {
            get { return Driver.FindElement(_container, Locators.ConfirmButton); }
        }

        public IWebElement PaymentTotalLabel
        {
            get { return Driver.FindElement(_container, Locators.PaymentTotalLabel); }
        }

        public string PaymentTotal
        {
            get { return PaymentTotalLabel.Text; }
        }

        public class Locators
        {
            public static By CancelButton = By.Id("pay-back");
            public static By ConfirmButton = By.Id("btn-pay-submit");
            public static By PaymentTotalLabel = By.XPath(".//div[@class='form-inner-totaltext']");
        }
    }
}
