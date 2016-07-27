using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.OrderJourney.PartyPaymentPanel
{
    public abstract class UkPartyPaymentPanel : BasePartyPaymentPanel
    {
        protected UkPartyPaymentPanel(TestSettings testSettings, IWebElement container) : base(testSettings, container)
        {
        }

        public new class Locators : BasePartyPaymentPanel.Locators
        {
            public static readonly By PayInFullPriceLabel = By.CssSelector("[value='Full']~label>[class='input-checkbox-price']>strong");
            public static readonly By PayDepositPriceLabel = By.CssSelector("[value='Deposit']~label>[class='input-checkbox-price']>strong");
            public static readonly By PayDepositCheckbox = By.CssSelector("[value='Deposit']");
            public static readonly By TodaysPaymentLabel = ;
            public static readonly By AdwChargeCheckbox = ;
            public static readonly By TotalPriceLabel = ;
            
        }
    }
}
