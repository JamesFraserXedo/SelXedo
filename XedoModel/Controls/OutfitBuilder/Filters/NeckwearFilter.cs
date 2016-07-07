﻿using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace Core.Controls.OutfitBuilder.Filters
{
    public class NeckwearFilter : ExpandableFilterBase
    {
        public NeckwearFilter(TestSettings testSettings) : base(testSettings)
        {
            FilterBase.Locators.Container = By.Id("filters-neckwear");
            SetActive();
        }
    }
}