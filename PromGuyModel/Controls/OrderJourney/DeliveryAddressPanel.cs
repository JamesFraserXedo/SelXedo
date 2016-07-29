using CommonModel.Controls.Billing;
using Core.CustomElements;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace PromGuyModel.Controls.OrderJourney
{
    public class DeliveryAddressPanel : BaseOrderBillingAddressPanel
    {
        public DeliveryAddressPanel(TestSettings testSettings) : base(testSettings)
        {
        }

        public Button EnterAddressButton
        {
            get { return new Button(Driver.FindElement(Locators.EnterAddressButton)); }
        }

        public Button UseSuggestedAddressButton
        {
            get { return new Button(Driver.FindElement(Locators.UseSuggestedAddressButton)); }
        }

        public Button ChangeAddressButton
        {
            get { return new Button(Driver.FindElement(Locators.ChangeAddressButton)); }
        }

        protected Inputbox BuildingNameInputbox
        {
            get { return new Inputbox(Driver.FindElement(Locators.OrganisationNameInputbox)); }
        }

        protected Inputbox CityInputbox
        {
            get { return new Inputbox(Driver.FindElement(Locators.Address3Inputbox)); }
        }

        public Selector StateSelect
        {
            get { return new Selector(Driver.FindElement(Locators.Address4Inputbox)); }
        }

        protected Inputbox ZipcodeInputbox
        {
            get { return new Inputbox(Driver.FindElement(Locators.PostcodeInputbox)); }
        }

        public Button UseEnteredAddressButton
        {
            get { return new Button(Driver.FindElement(Locators.UseEnteredAddressButton)); }
        }

        public string BuildingName
        {
            get { return BuildingNameInputbox.Text; }
            set { BuildingNameInputbox.SendKeys(value); }
        }

        public string City
        {
            get { return CityInputbox.Text; }
            set { CityInputbox.SendKeys(value); }
        }

        public string State
        {
            get { return StateSelect.SelectedOption.Text; }
            set { StateSelect.SelectByTextThenValue(value); }
        }

        public string Zipcode
        {
            get { return ZipcodeInputbox.Text; }
            set { ZipcodeInputbox.SendKeys(value); }
        }

        public new class Locators : BaseOrderBillingAddressPanel.Locators
        {
            public static readonly By EnterAddressButton = By.Id("btn-manual-address");
            public static readonly By UseSuggestedAddressButton = By.Id("btn-confirm-address");
            public static readonly By ChangeAddressButton = By.ClassName("remove-address-from-singlewearer");
            public static readonly By UseEnteredAddressButton = By.Id("btn-confirm-manual-address");
        }
    }
}
