using Core.CustomElements;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.Billing
{
    public abstract class UkOrderBillingAddressPanel : NotPgOrderBillingAddressPanel
    {
        protected UkOrderBillingAddressPanel(TestSettings testSettings) : base(testSettings)
        {
        }

        public InputBox PostcodeSearchInputbox
        {
            get { return new InputBox(Driver.FindElement(Locators.PostcodeSearchInputbox)); }
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

        public InputBox OrganisationNameInputbox
        {
            get { return new InputBox(Driver.FindElement(Locators.OrganisationNameInputbox)); }
        }

        public InputBox Address3Inputbox
        {
            get { return new InputBox(Driver.FindElement(Locators.Address3Inputbox)); }
        }

        public InputBox CityInputbox
        {
            get { return new InputBox(Driver.FindElement(Locators.CityInputbox)); }
        }

        public InputBox PostcodeInputbox
        {
            get { return new InputBox(Driver.FindElement(Locators.PostcodeInputbox)); }
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
