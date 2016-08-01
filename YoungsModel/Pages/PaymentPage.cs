using CommonModel.Pages.Payment;
using Core.Model.TestObjects.Bases;
using YoungsModel.Controls.TryOnPayment;

namespace YoungsModel.Pages
{
    public class PaymentPage : UkPaymentPage
    {
        public PaymentPage(TestSettings testSettings) : base(testSettings)
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
