using Core.CustomElements;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.Billing
{
    public abstract class NotPgOrderBillingAddressPanel : BaseOrderBillingAddressPanel
    {
        protected NotPgOrderBillingAddressPanel(TestSettings testSettings) : base(testSettings)
        {
        }

        public Button AddAddressButton
        {
            get { return new Button(Driver.FindElement(Locators.AddAddressButton)); }
        }

        public Button ConfirmSuggestedAddressButton
        {
            get { return new Button(Driver.FindElement(Locators.ConfirmSuggestedAddressButton)); }
        }

        public Button CancelConfirmedAddressButton
        {
            get { return new Button(Driver.FindElement(Locators.CancelConfirmedAddressButton)); }
        }
        
        public Button ConfirmEnteredAddressButton
        {
            get { return new Button(Driver.FindElement(Locators.ConfirmEnteredAddressButton)); }
        }

        public new class Locators : BaseOrderBillingAddressPanel.Locators
        {
            public static readonly By AddAddressButton = By.CssSelector("[onclick='addNewAddressToAddressBook()']");
            public static readonly By ConfirmSuggestedAddressButton = By.Id("confirm-address");
            public static readonly By CancelConfirmedAddressButton = By.ClassName("iconset-close");
            public static readonly By ConfirmEnteredAddressButton = By.Id("confirm-manual-address");
        }
    }
}
