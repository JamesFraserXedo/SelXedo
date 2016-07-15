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

        public InputBox CityInputbox
        {
            get { return new InputBox(Driver.FindElement(Container, Locators.AddressThreeInputbox)); }
        }

        public InputBox StateInputbox
        {
            get { return new InputBox(Driver.FindElement(Container, Locators.AddressFourInputbox)); }
        }

        public InputBox ZipCodeInputbox
        {
            get { return new InputBox(Driver.FindElement(Container, Locators.PostCodeInputbox)); }
        }
    }
}
