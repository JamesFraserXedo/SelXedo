using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.TryOnPayment.BillingAdress
{
    public abstract class UkBillingAddressPanel : ControlBase
    {
        protected UkBillingAddressPanel(TestSettings testSettings) : base(testSettings)
        {
        }

        protected Inputbox Address1Inputbox
        {
            get { return new Inputbox(Driver.FindElement(Locators.Address1Inputbox)); }
        }

        protected Inputbox Address2Inputbox
        {
            get { return new Inputbox(Driver.FindElement(Locators.Address2Inputbox)); }
        }

        protected Inputbox CityInputbox
        {
            get { return new Inputbox(Driver.FindElement(Locators.CityInputbox)); }
        }

        protected Inputbox PostcodeInputbox
        {
            get { return new Inputbox(Driver.FindElement(Locators.PostcodeInputbox)); }
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

        public string Address2
        {
            get { return Address2Inputbox.Text; }
            set { Address2Inputbox.SendKeys(value); }
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

        public string Country
        {
            get { return CountryInputbox.Text; }
            set { CountryInputbox.SendKeys(value); }
        }

        public class Locators
        {
            public static readonly By Address1Inputbox = By.Id("baddr1");
            public static readonly By Address2Inputbox = By.Id("baddr2");
            public static readonly By CityInputbox = By.Id("bcity");
            public static readonly By PostcodeInputbox = By.Id("bzip");
            public static readonly By CountryInputbox = By.Id("bcountry");
        }
    }
}
