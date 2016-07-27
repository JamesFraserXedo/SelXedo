using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.OrderJourney.PartyPaymentPanel
{
    public abstract class UsPartyPaymentPanel : BasePartyPaymentPanel
    {
        protected UsPartyPaymentPanel(TestSettings testSettings, IWebElement container) : base(testSettings, container)
        {
        }

        protected IWebElement PriceLabel
        {
            get { return Driver.FindElement(_container, Locators.PriceLabel); }
        }

        protected IWebElement DiscountLabel
        {
            get { return Driver.FindElement(_container, Locators.DiscountLabel); }
        }

        protected IWebElement TotalLabel
        {
            get { return Driver.FindElement(_container, Locators.TotalLabel); }
        }

        public string Price
        {
            get { return PriceLabel.Text; }
        }

        public string Discount
        {
            get { return DiscountLabel.Text; }
        }

        public string Total
        {
            get { return TotalLabel.Text; }
        }
        
        public new class Locators : BasePartyPaymentPanel.Locators
        {
            public static readonly By PriceLabel = By.ClassName("sub-total-amount");
            public static readonly By DiscountLabel = By.ClassName("sub-total-discount");
            public static readonly By TotalLabel = By.ClassName("total-amount");
        }
    }
}
