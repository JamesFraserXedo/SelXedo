using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.OrderJourney.PartyPaymentPanel
{
    public abstract class BaseAdwWarningPopup : PopupControlBase
    {
        protected BaseAdwWarningPopup(TestSettings testSettings) : base(testSettings)
        {
        }

        public IWebElement Container
        {
            get { return Driver.FindElement(Locators.Container); }
        }

        public override bool Active
        {
            get { return Driver.ElementDisplayed(Locators.Container); }
        }

        public Button ProceedButton
        {
            get { return new Button(Driver.FindElement(Container, Locators.ProceedButton)); }
        }

        public Button CancelButton
        {
            get { return new Button(Driver.FindElement(Container, Locators.CancelButton)); }
        }

        public new class Locators
        {
            public static readonly By Container = By.ClassName("modal-content");
            public static readonly By ProceedButton = By.Id("btn-outfit-payment-adw-confirmed");
            public static readonly By CancelButton = By.Id("btn-con");
        }
    }
}
