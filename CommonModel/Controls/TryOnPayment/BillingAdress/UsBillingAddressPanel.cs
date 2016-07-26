using Core.CustomElements;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace CommonModel.Controls.TryOnPayment.BillingAdress
{
    public abstract class UsBillingAddressPanel : ControlBase
    {
        protected UsBillingAddressPanel(TestSettings testSettings) : base(testSettings)
        {
        }

        public InputBox Address1Inputbox
        {
            get { return new InputBox(Driver.FindElement(Locators.Address1Inputbox)); }
        }

        public InputBox CityInputbox
        {
            get { return new InputBox(Driver.FindElement(Locators.CityInputbox)); }
        }

        public SelectElement StateSelect
        {
            get { return new SelectElement(Driver.FindElement(Locators.StateSelect)); }
        }

        public InputBox ZipcodeInputbox
        {
            get { return new InputBox(Driver.FindElement(Locators.ZipcodeInputbox)); }
        }

        public InputBox CountryInputbox
        {
            get { return new InputBox(Driver.FindElement(Locators.CountryInputbox)); }
        }

        public string Address1
        {
            get { return Address1Inputbox.Text; }
            set { Address1Inputbox.SendKeys(value); }
        }

        public string City
        {
            get { return CityInputbox.Text; }
            set { CityInputbox.SendKeys(value); }
        }

        public string State
        {
            get { return StateSelect.SelectedOption.Text; }
            set { StateSelect.SelectByText(value); }
        }

        public string Zipcode
        {
            get { return ZipcodeInputbox.Text; }
            set { ZipcodeInputbox.SendKeys(value); }
        }

        public string Country
        {
            get { return CountryInputbox.Text; }
            set { CountryInputbox.SendKeys(value); }
        }

        public class Locators
        {
            public static readonly By Address1Inputbox = By.CssSelector("[data-at='txt-address1']");
            public static readonly By CityInputbox = By.CssSelector("[data-at='txt-city']");
            public static readonly By StateSelect = By.CssSelector("[data-at='txt-state']");
            public static readonly By ZipcodeInputbox = By.CssSelector("[data-at='txt-zipcode']");
            public static readonly By CountryInputbox = By.CssSelector("[data-at='txt-country']");
        }
    }
}
