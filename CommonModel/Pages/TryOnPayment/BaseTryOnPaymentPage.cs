using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Pages.TryOnPayment
{
    public abstract class BaseTryOnPaymentPage : PageBase
    {
        protected BaseTryOnPaymentPage(TestSettings testSettings) : base(testSettings)
        {
        }

        public override bool IsLoaded()
        {
            return Driver.ElementDisplayed(Locators.EnterDefaultCreditCardDetailsButton);
        }

        public Button CancelButton
        {
            get { return new Button(Driver.FindElement(Locators.CancelButton)); }
        }

        public IWebElement TotalLabel
        {
            get { return Driver.FindElement(Locators.TotalLabel); }
        }
        
        public string Total
        {
            get { return TotalLabel.Text.Replace("Total", "").Trim(); }
        }

        public class Locators
        {
            public static readonly By EnterDefaultCreditCardDetailsButton = By.Id("enter-test-details");
            public static readonly By CancelButton = By.Id("pay-back");
            public static readonly By TotalLabel = By.ClassName("form-inner-totaltext");
            public static readonly By ConfirmButton = By.Id("btn-pay-submit");
        }
    }
}
