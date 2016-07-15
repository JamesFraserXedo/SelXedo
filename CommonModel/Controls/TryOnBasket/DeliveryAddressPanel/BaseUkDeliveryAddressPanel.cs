using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.TryOnBasket.DeliveryAddressPanel
{
    public abstract class BaseUkDeliveryAddressPanel : BaseDeliveryAddressPanel
    {
        protected BaseUkDeliveryAddressPanel(TestSettings testSettings) : base(testSettings)
        {
        }

        public InputBox AddressThreeInputbox
        {
            get { return new InputBox(Driver.FindElement(Container, Locators.AddressThreeInputbox)); }
        }

        public InputBox CityInputbox
        {
            get { return new InputBox(Driver.FindElement(Container, Locators.AddressFourInputbox)); }
        }

        public InputBox PostCodeInputbox
        {
            get { return new InputBox(Driver.FindElement(Container, Locators.PostCodeInputbox)); }
        }

        public InputBox SearchPostCodeInputbox
        {
            get { return new InputBox(Driver.FindElement(Container, Locators.SearchPostCodeInputbox)); }
        }

        public Button FindPostCodeButton
        {
            get { return new Button(Driver.FindElement(Container, Locators.FindPostCodeButton)); }
        }

        public new class Locators : BaseDeliveryAddressPanel.Locators
        {
            public static By SearchPostCodeInputbox = By.Id("postcodeField");
            public static By FindPostCodeButton = By.CssSelector("[class='postcode-lookup']>a");
        }
    }
}
