using CommonModel.Controls.Common.DatePicker;
using CommonModel.Pages;
using Core.Model.TestObjects.Bases;
using YoungsModel.Controls.TryOnBasket;

namespace YoungsModel.Pages
{
    public class TryOnBasketPage : BaseTryOnBasketPage
    {
        public TryOnBasketPage(TestSettings testSettings) : base(testSettings)
        {
        }

        public SizeInfoPanel SizeInfoPanel
        {
            get { return new SizeInfoPanel(TestSettings); }
        }

        public DeliveryAddressPanel DeliveryAddressPanel
        {
            get { return new DeliveryAddressPanel(TestSettings); }
        }

        public MinimisedDatePicker PreferredTryOnDatePicker
        {
            get { return new MinimisedDatePicker(TestSettings, Driver.FindElement(Locators.PreferredTryOnDatePicker)); }
        }

        public MinimisedDatePicker WeddingDatePicker
        {
            get { return new MinimisedDatePicker(TestSettings, Driver.FindElement(Locators.WeddingDatePicker)); }
        }
    }
}
