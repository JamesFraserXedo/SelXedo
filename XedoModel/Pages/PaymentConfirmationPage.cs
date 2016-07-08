using System;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using XedoModel.Controls.PaymentConfirmation;

namespace XedoModel.Pages
{
    class PaymentConfirmationPage : PageBase
    {
        public PaymentConfirmationPage(TestSettings testSettings) : base(testSettings)
        {
        }

        public PaymentForm PaymentForm
        {
            get { return new PaymentForm(TestSettings); }
        }

        public override bool IsLoaded()
        {
            return Driver.ElementDisplayed(PaymentForm.Locators.Container);
        }

        public override void SetupState()
        {
            throw new NotImplementedException();
        }
    }
}
