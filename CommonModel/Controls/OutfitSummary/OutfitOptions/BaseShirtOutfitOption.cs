﻿using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.OutfitSummary.OutfitOptions
{
    public abstract class BaseShirtOutfitOption : BaseOutfitOption
    {
        protected BaseShirtOutfitOption(TestSettings testSettings) : base(testSettings)
        {
        }

        public new class Locators : BaseOutfitOption.Locators
        {
            public new static readonly By Container = By.CssSelector("[class='outfit-options']>li:nth-of-type(4)");
        }
    }
}
