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

        public InputBox OrganisationNameInputbox
        {
            get { return new InputBox(Driver.FindElement(Container, Locators.OrganisationNameInputbox)); }
        }

        public InputBox AddressOneInputbox
        {
            get { return new InputBox(Driver.FindElement(Container, Locators.AddressOneInputbox)); }
        }

        public InputBox AddressTwoInputbox
        {
            get { return new InputBox(Driver.FindElement(Container, Locators.AddressTwoInputbox)); }
        }

        public Button UseEnteredAddressButton
        {
            get { return new Button(Driver.FindElement(Container, Locators.UseEnteredAddressButton)); }
        }
        
        public class Locators
        {
            public static By Container = By.ClassName("tryon-address-selection-container");

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
