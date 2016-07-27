using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace CommonModel.Controls.Billing
{
    public abstract class BaseOrderBillingAddressPanel : ControlBase
    {
        protected BaseOrderBillingAddressPanel(TestSettings testSettings) : base(testSettings)
        {
        }

        public Selector AddressBookSelector
        {
            get { return new Selector(Driver.FindElement(Locators.AddressBookSelector)); }
        }

        public IWebElement ConfirmedAddressLabel
        {
            get { return Driver.FindElement(Locators.ConfirmedAddressLabel); }
        }

        public InputBox Address1Inputbox
        {
            get { return new InputBox(Driver.FindElement(Locators.Address1Inputbox)); }
        }

        public InputBox Address2Inputbox
        {
            get { return new InputBox(Driver.FindElement(Locators.Address2Inputbox)); }
        }
            
        public InputBox ContactNumberInputbox
        {
            get { return new InputBox(Driver.FindElement(Locators.ContactNumberInputbox)); }
        }

        public bool AddressConfirmed
        {
            get { return Driver.ElementDisplayed(Locators.IsAddressConfirmedLabel); }
        }

        public string ConfirmedAddress
        {
            get { return ConfirmedAddressLabel.Text; }
        }

        public string AddressBook
        {
            get { return AddressBookSelector.SelectedOption.Text; }
            set { AddressBookSelector.SelectByTextThenValue(value); }
        }

        public string Address1
        {
            get { return Address1Inputbox.Text; }
            set { Address1Inputbox.SendKeys(value); }
        }

        public string Address2
        {
            get { return Address2Inputbox.Text; }
            set { Address2Inputbox.SendKeys(value); }
        }

        public string ContactNumber
        {
            get { return ContactNumberInputbox.Text; }
            set { ContactNumberInputbox.SendKeys(value); }
        }

        public class Locators
        {
            public static readonly By AddressBookSelector = By.Id("address-book-dropdown");
            public static readonly By IsAddressConfirmedLabel = By.ClassName("confirmedtext");
            public static readonly By ConfirmedAddressLabel = By.CssSelector("[class*='displayAddress confirmed']>p");
            public static readonly By Address1Inputbox = By.Id("address1");
            public static readonly By Address2Inputbox = By.Id("address2");

            public static readonly By OrganisationNameInputbox = By.Id("organisationName");
            public static readonly By Address3Inputbox = By.Id("address3");
            public static readonly By Address4Inputbox = By.Id("address4");
            public static readonly By PostcodeInputbox = By.Id("postcode");

            public static readonly By ContactNumberInputbox = By.Id("ContactNumber");
        }
    }
}
