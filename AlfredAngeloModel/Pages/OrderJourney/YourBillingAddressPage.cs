using AlfredAngeloModel.Controls.OrderJourney;
using CommonModel.Pages.OrderJourney.YourBillingAddressPage;
using Core.Model.TestObjects.Bases;

namespace AlfredAngeloModel.Pages.OrderJourney
{
    public class YourBillingAddressPage : BaseYourBillingAddressPage
    {
        public YourBillingAddressPage(TestSettings testSettings) : base(testSettings)
        {
        }

        public BillingAddressPanel BillingAddressPanel
        {
            get { return new BillingAddressPanel(TestSettings); }
        }
    }
}
