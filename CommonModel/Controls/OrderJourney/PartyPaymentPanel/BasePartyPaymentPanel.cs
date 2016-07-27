using Core.CustomElements;
using Core.Model.SupportTools;
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

        public bool IsChild
        {
            get { return Driver.ElementDisplayed(_container, Locators.ChildBadge); }
        }

        protected IWebElement RoleLabel
        {
            get { return Driver.FindElement(_container, Locators.RoleLabel); }
        }

        protected IWebElement NameLabel
        {
            get { return Driver.FindElement(_container, Locators.NameLabel); }
        }

        public string Role
        {
            get { return RoleLabel.Text.Replace("Role:", "").Trim(); }
        }

        public string Name
        {
            get { return NameLabel.Text; }
        }

        public Checkbox PayLaterCheckbox
        {
            get { return new Checkbox(Driver.FindElement(_container, Locators.PayLaterCheckbox)); }
        }

        public Checkbox PayInFullCheckbox
        {
            get { return new Checkbox(Driver.FindElement(_container, Locators.PayInFullCheckbox)); }
        }

        public class Locators
        {
            public static readonly By ChildBadge = By.ClassName("child-badge");
            public static readonly By RoleLabel = By.CssSelector("p>strong");
            public static readonly By NameLabel = By.ClassName("wearer-name");
            public static readonly By PayLaterCheckbox = By.CssSelector("[value='Deferred']");
            public static readonly By PayInFullCheckbox = By.CssSelector("[value='Full']");
        }
    }
}
