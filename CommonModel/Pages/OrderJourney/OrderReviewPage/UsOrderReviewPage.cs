using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Pages.OrderJourney.OrderReviewPage
{
    public abstract class UsOrderReviewPage : BaseOrderReviewPage
    {
        protected UsOrderReviewPage(TestSettings testSettings) : base(testSettings)
        {
        }

        protected IWebElement TaxChargeMessageLabel
        {
            get { return Driver.FindElement(Locators.TaxChargeMessageLabel); }
        }

        protected IWebElement DamageAndHandlingFeeMessageLabel
        {
            get { return Driver.FindElement(Locators.DamageAndHandlingFeeMessageLabel); }
        }

        public string TaxChargeMessage
        {
            get { return TaxChargeMessageLabel.Text; }
        }

        public string DamageAndHandlingFeeMessage
        {
            get { return DamageAndHandlingFeeMessageLabel.Text; }
        }

        public new class Locators : BaseOrderReviewPage.Locators
        {
            public static readonly By TaxChargeMessageLabel = By.CssSelector("[class='additional-total-order-detail']:nth-of-type(1)");
            public static readonly By DamageAndHandlingFeeMessageLabel = By.CssSelector("[class='additional-total-order-detail']:nth-of-type(2)");
        }
    }
}
