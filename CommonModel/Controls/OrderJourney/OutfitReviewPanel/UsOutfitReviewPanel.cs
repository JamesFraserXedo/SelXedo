using System.Collections.Generic;
using System.Collections.ObjectModel;
using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.OrderJourney.OutfitReviewPanel
{
    public abstract class UsOutfitReviewPanel : BaseOutfitReviewPanel
    {
        protected UsOutfitReviewPanel(TestSettings testSettings, IWebElement container) : base(testSettings, container)
        {
        }

        public IWebElement TaxChargeLabel
        {
            get { return Driver.FindElement(_container, Locators.TaxChargeLabel); }
        }

        public IWebElement DamageHandlingChargeLabel
        {
            get { return Driver.FindElement(_container, Locators.DamageHandlingChargeLabel); }
        }

        public IWebElement DiscountMessageLabel
        {
            get { return Driver.FindElement(_container, Locators.DiscountMessageLabel); }
        }

        public IWebElement TotalPriceLabel
        {
            get { return Driver.FindElement(_container, Locators.TotalPriceLabel); }
        }

        public Link EditSizesLink
        {
            get { return new Link(Driver.FindElement(_container, Locators.EditSizesLink)); }
        }

        public string TaxCharge
        {
            get { return TaxChargeLabel.Text; }
        }

        public string DamageHandlingCharge
        {
            get { return DamageHandlingChargeLabel.Text; }
        }

        public string DiscountMessage
        {
            get { return DiscountMessageLabel.Text; }
        }

        public string TotalPrice
        {
            get { return TotalPriceLabel.Text; }
        }

        public new class Locators : BaseOutfitReviewPanel.Locators
        {
            public static readonly By TaxChargeLabel = By.CssSelector("[class='additional-payment-detail border']>span");
            public static readonly By DamageHandlingChargeLabel = By.CssSelector("[class='additional-payment-detail']>span");
            public static readonly By DiscountMessageLabel = By.CssSelector("[class='payment-wearer-discount-label']");
            public static readonly By TotalPriceLabel = By.CssSelector("[class='total-price-display']");
            public static readonly By EditSizesLink = By.CssSelector("[class='edit-details']>a");
        }
    }
}
