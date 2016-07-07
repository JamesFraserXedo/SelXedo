using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Core.Controls.PaymentConfirmation
{
    class BillingAddressForm : ControlBase
    {
        private IWebElement _container;

        public BillingAddressForm(TestSettings testSettings, IWebElement container)
            : base(testSettings)
        {
            _container = container;
        }

        public InputBox AddressInputBox
        {
            get { return new InputBox(Driver.FindElement(_container, Locators.AddressInputBox)); }
        }

        public InputBox CityInputBox
        {
            get { return new InputBox(Driver.FindElement(_container, Locators.CityInputBox)); }
        }

        public SelectElement StateSelect
        {
            get { return new SelectElement(Driver.FindElement(_container, Locators.StateSelect)); }
        }

        public InputBox ZipcodeInputBox
        {
            get { return new InputBox(Driver.FindElement(_container, Locators.ZipcodeInputBox)); }
        }

        public InputBox CountryInputBox
        {
            get { return new InputBox(Driver.FindElement(_container, Locators.CountryInputBox)); }
        }

        public class Locators
        {
            public static By AddressInputBox = By.Id("Address");
            public static By CityInputBox = By.Id("City");
            public static By StateSelect = By.Id("State");
            public static By ZipcodeInputBox = By.Id("ZipCode");
            public static By CountryInputBox = By.Id("Country");
        }
    }
}
