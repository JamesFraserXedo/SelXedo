using CommonModel.Controls.Common.DatePicker;
using CommonModel.Pages;
using Core.Model.TestObjects.Bases;
using XedoModel.Controls.TryOnBasket;

namespace XedoModel.Pages
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
