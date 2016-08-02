using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Pages.OrderJourney.OrderReviewPage
{
    public abstract class UkOrderReviewPage : BaseOrderReviewPage
    {
        protected UkOrderReviewPage(TestSettings testSettings) : base(testSettings)
        {
        }

        protected IWebElement TotalOrderValueLabel
        {
            get { return Driver.FindElement(Locators.TotalOrderValueLabel); }
        }

        protected IWebElement AdwChargeLabel
        {
            get { return Driver.FindElement(Locators.AdwChargeLabel); }
        }

        public string TotalOrderValue
        {
            get { return TotalOrderValueLabel.Text; }
        }

        public string AdwCharge
        {
            get { return AdwChargeLabel.Text.Replace("Inc ADW:", "").Trim(); }
        }

        public new class Locators : BaseOrderReviewPage.Locators
        {
            public static readonly By TotalOrderValueLabel = By.CssSelector("[class='order-summary-sub-total']>[class='order-summary-total total']");
            public static readonly By AdwChargeLabel = By.CssSelector("[class='additional-total-order-detail']");
        }
    }
}
