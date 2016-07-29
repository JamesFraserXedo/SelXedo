using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Pages
{
    public abstract class BaseTryOnConfirmationPage : PageBase
    {
        protected BaseTryOnConfirmationPage(TestSettings testSettings) : base(testSettings)
        {
        }

        public override bool IsLoaded()
        {
            return Driver.ElementDisplayed(Locators.BackToOrderSummaryLink);
        }

        public IWebElement OrderNumberLabel
        {
            get { return Driver.FindElement(Locators.OrderNumberLabel); }
        }

        public Button BackToOrderSummaryButton
        {
            get { return new Button(Driver.FindElement(Locators.BackToOrderSummaryLink)); }
        }

        public string OrderNumber
        {
            get { return OrderNumberLabel.Text.Replace("Order number ", ""); }
        }

        public bool Successful
        {
            get { return Driver.ElementDisplayed(Locators.SuccessLabel); }
        }

        public class Locators
        {
            public static readonly By SuccessLabel = By.ClassName("sage-status-holder confirmed");
            public static readonly By DeniedLabel = By.ClassName("sage-status-holder denied");
            public static readonly By OrderNumberLabel = By.ClassName("sage-order-number-text");
            public static readonly By BackToOrderSummaryLink = By.ClassName("link blue");
        }
    }
}
