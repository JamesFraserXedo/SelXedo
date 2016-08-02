using Core.CustomElements;
using Core.Model.SupportTools;
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

        protected Inputbox Address1Inputbox
        {
            get { return new Inputbox(Driver.FindElement(Locators.Address1Inputbox)); }
        }

        protected Inputbox CityInputbox
        {
            get { return new Inputbox(Driver.FindElement(Locators.CityInputbox)); }
        }

        protected Selector StateSelect
        {
            get { return new Selector(Driver.FindElement(Locators.StateSelect)); }
        }

        protected Inputbox ZipcodeInputbox
        {
            get { return new Inputbox(Driver.FindElement(Locators.ZipcodeInputbox)); }
        }

        protected Inputbox CountryInputbox
        {
            get { return new Inputbox(Driver.FindElement(Locators.CountryInputbox)); }
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
            set { StateSelect.SelectByTextThenValue(value); }
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
