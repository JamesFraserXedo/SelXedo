using System.Collections.Generic;
using System.Collections.ObjectModel;
using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.OrderJourney.OutfitReviewPanel
{
    public abstract class UkOutfitReviewPanel : BaseOutfitReviewPanel
    {
        protected UkOutfitReviewPanel(TestSettings testSettings, IWebElement container) : base(testSettings, container)
        {
        }

        public IWebElement OutfitPriceLabel
        {
            get { return Driver.FindElement(_container, Locators.OutfitPriceLabel); }
        }

        public IWebElement DepositPriceLabel
        {
            get { return Driver.FindElement(_container, Locators.DepositPriceLabel); }
        }

        public IWebElement DepositTypeLabel
        {
            get { return Driver.FindElement(_container, Locators.DepositTypeLabel); }
        }

        public string OutfitPrice
        {
            get { return OutfitPriceLabel.Text; }
        }

        public string DepositPrice
        {
            get { return DepositPriceLabel.Text; }
        }

        public string DepositType
        {
            get { return DepositTypeLabel.Text; }
        }

        public new class Locators : BaseOutfitReviewPanel.Locators
        {
            public static readonly By OutfitPriceLabel = By.CssSelector("div:not([class='deposit-payment'])>[class='total-price-display']");
            public static readonly By DepositPriceLabel = By.CssSelector("[class='deposit-payment']>[class='total-price-display']");
            public static readonly By DepositTypeLabel = By.CssSelector("[class='deposit-payment']>[class='order-summary-label']");
        }
    }
}
