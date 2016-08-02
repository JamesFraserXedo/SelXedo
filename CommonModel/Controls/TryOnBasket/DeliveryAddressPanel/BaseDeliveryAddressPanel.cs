using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace CommonModel.Controls.TryOnBasket.DeliveryAddressPanel
{
    public abstract class BaseDeliveryAddressPanel : ControlBase
    {
        protected BaseDeliveryAddressPanel(TestSettings testSettings) : base(testSettings)
        {
        }

        public IWebElement Container
        {
            get { return Driver.FindElement(Locators.Container); }
        }

        public Selector AddressBookSelect
        {
            get { return new Selector(Driver.FindElement(Container, Locators.AddressBookSelect)); }
        }

        public Button UseThisExistingAddressButton
        {
            get { return new Button(Driver.FindElement(Container, Locators.UseThisExistingAddressButton)); }
        }

        public Button EnterAddressButton
        {
            get { return new Button(Driver.FindElement(Container, Locators.EnterAddressButton)); }
        }

        protected Inputbox OrganisationNameInputbox
        {
            get { return new Inputbox(Driver.FindElement(Container, Locators.OrganisationNameInputbox)); }
        }

        protected Inputbox Address1Inputbox
        {
            get { return new Inputbox(Driver.FindElement(Container, Locators.AddressOneInputbox)); }
        }

        protected Inputbox Address2Inputbox
        {
            get { return new Inputbox(Driver.FindElement(Container, Locators.AddressTwoInputbox)); }
        }

        public Button UseEnteredAddressButton
        {
            get { return new Button(Driver.FindElement(Container, Locators.UseEnteredAddressButton)); }
        }

        public string OrganisationName
        {
            get { return OrganisationNameInputbox.Text; }
            set { OrganisationNameInputbox.SendKeys(value); }
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
        
        public class Locators
        {
            public static By Container = By.CssSelector("[class='tryon-address-selection-container']");

            public static By AddressBookSelect = By.Id("address-book-dropdown");
            public static By UseThisExistingAddressButton = By.Id("btn-confirm-address");
            public static By EnterAddressButton = By.Id("btn-manual-address");

            public static By OrganisationNameInputbox = By.CssSelector("[data-at='txt-try-on-organisation']");
            public static By AddressOneInputbox = By.CssSelector("[data-at='txt-try-on-address1']");
            public static By AddressTwoInputbox = By.CssSelector("[data-at='txt-try-on-address2']");
            public static By AddressThreeInputbox = By.CssSelector("[data-at='txt-try-on-address3']");
            public static By AddressFourInputbox = By.CssSelector("[data-at='txt-try-on-address4']");
            public static By PostCodeInputbox = By.CssSelector("[data-at='txt-try-on-postcode']");
            public static By UseEnteredAddressButton = By.CssSelector("[data-at='btn-try-on-basket']");


        }
    }
}
