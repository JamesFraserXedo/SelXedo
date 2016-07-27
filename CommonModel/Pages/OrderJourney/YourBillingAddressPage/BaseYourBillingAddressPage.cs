using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Pages.OrderJourney.YourBillingAddressPage
{
    public abstract class BaseYourBillingAddressPage : PageBase
    {
        protected BaseYourBillingAddressPage(TestSettings testSettings) : base(testSettings)
        {
        }

        public override bool IsLoaded()
        {
            return Driver.ElementDisplayed(Locators.PaymentOptionsButton);
        }

        public Button BackButton
        {
            get { return new Button(Driver.FindElement(Locators.BackButton)); }
        }

        public Button PaymentOptionsButton
        {
            get { return new Button(Driver.FindElement(Locators.PaymentOptionsButton)); }
        }

        public class Locators
        {
            public static readonly By BackButton = By.CssSelector("[data-at='btn-outfit-delivery-prev']");
            public static readonly By PaymentOptionsButton = By.CssSelector("[data-at='btn-outfit-delivery-next']");
        }
    }
}
