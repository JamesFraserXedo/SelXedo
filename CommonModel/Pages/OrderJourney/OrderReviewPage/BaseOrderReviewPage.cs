using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Pages.OrderJourney.OrderReviewPage
{
    public abstract class BaseOrderReviewPage : PageBase
    {
        protected BaseOrderReviewPage(TestSettings testSettings) : base(testSettings)
        {
        }

        public override bool IsLoaded()
        {
            return Driver.ElementDisplayed(Locators.OutfitReviewPanels);
        }

        protected IWebElement BillingAddressLabel
        {
            get { return Driver.FindElement(Locators.BillingAddressLabel); }
        }

        protected IWebElement ContactNumberLabel
        {
            get { return Driver.FindElement(Locators.ContactNumberLabel); }
        }

        public Inputbox DiscountCodeInputbox
        {
            get { return new Inputbox(Driver.FindElement(Locators.DiscountCodeInputbox)); }
        }

        public Button AddDiscountCodeButton
        {
            get { return new Button(Driver.FindElement(Locators.AddDiscountCodeButton)); }
        }

        protected IWebElement DeadlineLabel
        {
            get { return Driver.FindElement(Locators.DeadlineLabel); }
        }

        public Checkbox TermsAndConditionsCheckbox
        {
            get { return new Checkbox(Driver.FindElement(Locators.TermsAndConditionsCheckbox)); }
        }

        public Button BackButton
        {
            get { return new Button(Driver.FindElement(Locators.BackButton)); }
        }

        public Button ContinueButton
        {
            get { return new Button(Driver.FindElement(Locators.ContinueButton)); }
        }

        protected IWebElement TodaysPaymentLabel
        {
            get { return Driver.FindElement(Locators.TodaysPaymentLabel); }
        }

        public string BillingAddress
        {
            get { return BillingAddressLabel.Text; }
        }

        public string ContactNumber
        {
            get { return ContactNumberLabel.Text; }
        }

        public string Deadline
        {
            get { return DeadlineLabel.Text; }
        }

        public string TodaysPayment
        {
            get { return TodaysPaymentLabel.Text; }
        }
        
        public class Locators
        {
            public static readonly By OutfitReviewPanels = By.CssSelector("[class='row wearer-order-summary-panel-wrap']");
            public static readonly By BillingAddressLabel = By.CssSelector("[class='row order-billing-address'] p:nth-of-type(1)");
            public static readonly By ContactNumberLabel = By.CssSelector("[class='row order-billing-address'] p:nth-of-type(2)");
            public static readonly By DiscountCodeInputbox = By.Id("DiscountCode");
            public static readonly By AddDiscountCodeButton = By.Id("btn-add-discount-code");
            public static readonly By DeadlineLabel = By.CssSelector("[class='order-area-intro']>p");
            public static readonly By TermsAndConditionsCheckbox = By.CssSelector("[data-at='chk-check-order-tandc']");
            public static readonly By BackButton = By.Id("btn-outfit-payment-prev");
            public static readonly By ContinueButton = By.CssSelector("[data-at='btn-outfit-summary-next']");
            public static readonly By TodaysPaymentLabel = By.CssSelector("[class='order-total-wrap']>[class='order-summary-total total']");
        }
    }
}
