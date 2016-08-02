using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.Billing
{
    public abstract class UkOrderBillingAddressPanel : NotPgOrderBillingAddressPanel
    {
        protected UkOrderBillingAddressPanel(TestSettings testSettings) : base(testSettings)
        {
        }

        protected Inputbox PostcodeSearchInputbox
        {
            get { return new Inputbox(Driver.FindElement(Locators.PostcodeSearchInputbox)); }
        }

        public Button FindPostcodeButton
        {
            get { return new Button(Driver.FindElement(Locators.FindPostcodeButton)); }
        }

        public Selector PostcodeAddressSelect
        {
            get { return new Selector(Driver.FindElement(Locators.PostcodeAddressSelect)); }
        }

        public Button ManuallyEnterAddressButton
        {
            get { return new Button(Driver.FindElement(Locators.ManuallyEnterAddressButton)); }
        }

        public Button ConfirmPostcodeAddressButton
        {
            get { return new Button(Driver.FindElement(Locators.ConfirmPostcodeAddressButton)); }
        }

        protected Inputbox OrganisationNameInputbox
        {
            get { return new Inputbox(Driver.FindElement(Locators.OrganisationNameInputbox)); }
        }

        protected Inputbox Address3Inputbox
        {
            get { return new Inputbox(Driver.FindElement(Locators.Address3Inputbox)); }
        }

        protected Inputbox CityInputbox
        {
            get { return new Inputbox(Driver.FindElement(Locators.CityInputbox)); }
        }

        protected Inputbox PostcodeInputbox
        {
            get { return new Inputbox(Driver.FindElement(Locators.PostcodeInputbox)); }
        }

        public string PostcodeSearch
        {
            get { return PostcodeInputbox.Text; }
            set { PostcodeInputbox.SendKeys(value); }
        }

        public string PostcodeAddress
        {
            get { return PostcodeAddressSelect.SelectedOption.Text; }
            set { PostcodeAddressSelect.SelectByTextThenValue(value); }
        }

        public string OrganisationName
        {
            get { return OrganisationNameInputbox.Text; }
            set { OrganisationNameInputbox.SendKeys(value); }
        }

        public string Address3
        {
            get { return Address3Inputbox.Text; }
            set { Address3Inputbox.SendKeys(value); }
        }

        public string City
        {
            get { return CityInputbox.Text; }
            set { CityInputbox.SendKeys(value); }
        }

        public string Postcode
        {
            get { return PostcodeInputbox.Text; }
            set { PostcodeInputbox.SendKeys(value); }
        }
            
        public new class Locators : NotPgOrderBillingAddressPanel.Locators
        {
            public static readonly By PostcodeSearchInputbox = By.Id("postcodeField");
            public static readonly By FindPostcodeButton = By.Id("look-up-postcode");
            public static readonly By PostcodeAddressSelect = By.Id("post-code-dropdown");
            public static readonly By ManuallyEnterAddressButton = By.Id("enter-manual-address");
            public static readonly By ConfirmPostcodeAddressButton = By.Id("confirm-postcode-lookup-address");
            public static readonly By OrganisationNameInputbox = By.Id("organisationName");
            public static readonly By Address3Inputbox = By.Id("address3");
            public static readonly By CityInputbox = By.Id("address4");
            public static readonly By PostcodeInputbox = By.Id("postcode");
        }
    }
}
