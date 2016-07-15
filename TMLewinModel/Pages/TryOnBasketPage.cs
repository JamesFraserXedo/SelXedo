﻿using CommonModel.Pages;
using Core.Model.TestObjects.Bases;
using TMLewinModel.Controls.Common;
using TMLewinModel.Controls.TryOnBasket;

namespace TMLewinModel.Pages
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

        public DatePicker PreferredTryOnDatePicker
        {
            get { return new DatePicker(TestSettings, Driver.FindElement(Locators.PreferredTryOnDatePicker)); }
        }

        public DatePicker WeddingDatePicker
        {
            get { return new DatePicker(TestSettings, Driver.FindElement(Locators.WeddingDatePicker)); }
        }
    }
}
