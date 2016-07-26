using CommonModel.Pages.TryOnPayment;
using Core.Model.TestObjects.Bases;
using XedoModel.Controls.TryOnPayment;

namespace XedoModel.Pages
{
    public class TryOnPaymentPage : UsTryOnPaymentPage
    {
        public TryOnPaymentPage(TestSettings testSettings) : base(testSettings)
        {
        }

        public BillingAddressPanel BillingAddressPanel
        {
            get { return new BillingAddressPanel(TestSettings); }
        }

        public ConfirmationMethodPanel ConfirmationMethodPanel
        {
            get { return new ConfirmationMethodPanel(TestSettings); }
        }
    }
}
