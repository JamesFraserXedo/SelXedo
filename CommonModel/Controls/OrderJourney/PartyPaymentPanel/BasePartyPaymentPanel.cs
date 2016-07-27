using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.OrderJourney.PartyPaymentPanel
{
    public abstract class BasePartyPaymentPanel : ControlBase
    {
        protected IWebElement _container;
        protected BasePartyPaymentPanel(TestSettings testSettings, IWebElement container) : base(testSettings)
        {
            _container = container;
        }

        public class Locators
        {
            public static readonly By ChildBadge = By.ClassName("child-badge");
            public static readonly By RoleLabel = By.CssSelector("p>strong");
            public static readonly By NameLabel = By.ClassName("wearer-name");
            public static readonly By PayLaterCheckbox = By.CssSelector("[value='Deferred']");
            /*
             * Pay in full option
             * Price
             * No outfit selected
             
             UK
             * Price - pay full
             * Price - pay 50%
             * Pay 50%
             * Charged today
             * ADW Charge
              
             US
             * Discount
             * Total
             
             
             */
        }
    }
}
