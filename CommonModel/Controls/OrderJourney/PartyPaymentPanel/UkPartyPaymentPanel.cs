using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.OrderJourney.PartyPaymentPanel
{
    public abstract class UkPartyPaymentPanel : BasePartyPaymentPanel
    {
        protected UkPartyPaymentPanel(TestSettings testSettings, IWebElement container) : base(testSettings, container)
        {
        }

        protected IWebElement PayInFullPriceLabel
        {
            get { return Driver.FindElement(_container, Locators.PayInFullPriceLabel); }
        }

        protected IWebElement PayDepositPriceLabel
        {
            get { return Driver.FindElement(_container, Locators.PayDepositPriceLabel); }
        }

        public Checkbox PayDepositCheckbox
        {
            get { return new Checkbox(Driver.FindElement(_container, Locators.PayDepositCheckbox)); }
        }

        protected IWebElement TodaysPaymentLabel
        {
            get { return Driver.FindElement(_container, Locators.TodaysPaymentLabel); }
        }

        public Checkbox AdwChargeCheckbox
        {
            get { return new Checkbox(Driver.FindElement(_container, Locators.AdwChargeCheckbox)); }
        }

        protected IWebElement AdwChargeLabel
        {
            get { return Driver.FindElement(_container, Locators.AdwChargeLabel); }
        }

        protected IWebElement OutfitPriceLabel
        {
            get { return Driver.FindElement(_container, Locators.OutfitPriceLabel); }
        }

        public string PayInFullPrice
        {
            get { return PayInFullPriceLabel.Text; }
        }

        public string PayDepositPrice
        {
            get { return PayDepositPriceLabel.Text; }
        }

        public string TodaysPayment
        {
            get { return TodaysPaymentLabel.Text; }
        }

        public string AdwCharge
        {
            get { return AdwChargeLabel.Text; }
        }

        public string OutfitPrice
        {
            get { return OutfitPriceLabel.Text; }
        }

        public new class Locators : BasePartyPaymentPanel.Locators
        {
            public static readonly By PayInFullPriceLabel = By.CssSelector("[value='Full']~label>[class='input-checkbox-price']>strong");
            public static readonly By PayDepositPriceLabel = By.CssSelector("[value='Deposit']~label>[class='input-checkbox-price']>strong");
            public static readonly By PayDepositCheckbox = By.CssSelector("[value='Deposit']");
            public static readonly By TodaysPaymentLabel = By.CssSelector("[class*='payment-wearer-price today-price']");
            public static readonly By AdwChargeCheckbox = By.ClassName("check-adw-charge");
            public static readonly By AdwChargeLabel = By.CssSelector("[class='label-adw-charge']>span");
            public static readonly By OutfitPriceLabel = By.ClassName("payment-wearer-price outfit-price");
            
        }
    }
}
