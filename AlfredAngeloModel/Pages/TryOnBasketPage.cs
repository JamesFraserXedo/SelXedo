using AlfredAngeloModel.Controls.Common;
using AlfredAngeloModel.Controls.TryOnBasket;
using CommonModel.Controls.Common.DatePicker;
using CommonModel.Pages;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;

namespace AlfredAngeloModel.Pages
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
