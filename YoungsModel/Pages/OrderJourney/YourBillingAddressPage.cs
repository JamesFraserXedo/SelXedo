﻿using CommonModel.Pages.OrderJourney.YourBillingAddressPage;
using Core.Model.TestObjects.Bases;
using YoungsModel.Controls.OrderJourney;

namespace YoungsModel.Pages.OrderJourney
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
