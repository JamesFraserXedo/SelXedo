using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;

namespace CommonModel.Controls.TryOnBasket.DeliveryAddressPanel
{
    public abstract class BaseUsDeliveryAddressPanel : BaseDeliveryAddressPanel
    {
        protected BaseUsDeliveryAddressPanel(TestSettings testSettings) : base(testSettings)
        {
        }

        protected Inputbox CityInputbox
        {
            get { return new Inputbox(Driver.FindElement(Container, Locators.AddressThreeInputbox)); }
        }

        protected Inputbox StateInputbox
        {
            get { return new Inputbox(Driver.FindElement(Container, Locators.AddressFourInputbox)); }
        }

        protected Inputbox ZipCodeInputbox
        {
            get { return new Inputbox(Driver.FindElement(Container, Locators.PostCodeInputbox)); }
        }

        public string City
        {
            get { return CityInputbox.Text; }
            set { CityInputbox.SendKeys(value); }
        }

        public string State
        {
            get { return StateInputbox.Text; }
            set { StateInputbox.SendKeys(value); }
        }

        public string ZipCode
        {
            get { return ZipCodeInputbox.Text; }
            set { ZipCodeInputbox.SendKeys(value); }
        }
    }
}
