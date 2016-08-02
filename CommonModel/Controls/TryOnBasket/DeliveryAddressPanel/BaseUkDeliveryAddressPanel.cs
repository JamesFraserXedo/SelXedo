using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace CommonModel.Controls.TryOnBasket.DeliveryAddressPanel
{
    public abstract class BaseUkDeliveryAddressPanel : BaseDeliveryAddressPanel
    {
        protected BaseUkDeliveryAddressPanel(TestSettings testSettings) : base(testSettings)
        {
        }

        protected Inputbox Address3Inputbox
        {
            get { return new Inputbox(Driver.FindElement(Container, Locators.AddressThreeInputbox)); }
        }

        protected Inputbox CityInputbox
        {
            get { return new Inputbox(Driver.FindElement(Container, Locators.AddressFourInputbox)); }
        }

        protected Inputbox PostCodeInputbox
        {
            get { return new Inputbox(Driver.FindElement(Container, Locators.PostCodeInputbox)); }
        }

        protected Inputbox SearchPostCodeInputbox
        {
            get { return new Inputbox(Driver.FindElement(Container, Locators.SearchPostCodeInputbox)); }
        }

        public Button FindPostCodeButton
        {
            get { return new Button(Driver.FindElement(Container, Locators.FindPostCodeButton)); }
        }

        public Selector PostCodeAddressSelect
        {
            get { return new Selector(Driver.FindElement(Container, Locators.PostCodeAddressSelect)); }
        }

        public Button UsePostCodeAddressButton
        {
            get { return new Button(Driver.FindElement(Container, Locators.UsePostCodeAddressButton)); }
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

        public string PostCode
        {
            get { return PostCodeInputbox.Text; }
            set { PostCodeInputbox.SendKeys(value); }
        }

        public string SearchPostCode
        {
            get { return SearchPostCodeInputbox.Text; }
            set { SearchPostCodeInputbox.SendKeys(value); }
        }

        public new class Locators : BaseDeliveryAddressPanel.Locators
        {
            public static By SearchPostCodeInputbox = By.Id("postcodeField");
            public static By FindPostCodeButton = By.CssSelector("[class='postcode-lookup']>a");
            public static By PostCodeAddressSelect = By.Id("post-code-dropdown");
            public static By UsePostCodeAddressButton = By.CssSelector("[class='btn-confirm-postcode button primary-cta']");
        }
    }
}
