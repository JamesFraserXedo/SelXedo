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

        public Inputbox CityInputbox
        {
            get { return new Inputbox(Driver.FindElement(Container, Locators.AddressThreeInputbox)); }
        }

        public Inputbox StateInputbox
        {
            get { return new Inputbox(Driver.FindElement(Container, Locators.AddressFourInputbox)); }
        }

        public Inputbox ZipCodeInputbox
        {
            get { return new Inputbox(Driver.FindElement(Container, Locators.PostCodeInputbox)); }
        }
    }
}
