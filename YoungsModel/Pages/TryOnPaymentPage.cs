﻿using CommonModel.Pages.TryOnPayment;
using Core.Model.TestObjects.Bases;
using YoungsModel.Controls.TryOnPayment;

namespace YoungsModel.Pages
{
    public class TryOnPaymentPage : UkTryOnPaymentPage
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