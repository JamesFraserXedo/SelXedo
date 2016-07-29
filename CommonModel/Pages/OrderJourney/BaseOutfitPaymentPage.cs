using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Pages.OrderJourney
{
    public abstract class BaseOutfitPaymentPage : PageBase
    {
        protected BaseOutfitPaymentPage(TestSettings testSettings) : base(testSettings)
        {
        }

        public override bool IsLoaded()
        {
            return Driver.ElementDisplayed(Locators.YourOutfit);
        }

        public Button BackButton
        {
            get { return new Button(Driver.FindElement(Locators.BackButton)); }
        }

        public Button ReviewYourOrderButton
        {
            get { return new Button(Driver.FindElement(Locators.ReviewYourOrderButton)); }
        }

        public class Locators
        {
            public static readonly By BackButton = By.CssSelector("[data-at='btn-outfit-payment-prev']");
            public static readonly By ReviewYourOrderButton = By.CssSelector("[data-at='btn-outfit-payment-next']");
            public static readonly By YourOutfit = By.CssSelector("[class='wearer-payment-panel-wrap complete']:nth-of-type(2)");
            public static readonly By PartyOutfits = By.CssSelector("[class='wearer-payment-panel-wrap complete']:not(:nth-of-type(2))");
        }
    }
}
