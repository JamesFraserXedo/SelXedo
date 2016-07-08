﻿using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace XedoModel.Controls.OutfitBuilder.Filters
{
    public class SuitFilter : ExpandableFilterBase
    {
        public SuitFilter(TestSettings testSettings) : base(testSettings)
        {
            FilterBase.Locators.Container = By.Id("filters-suits");
            SetActive();
        }
    }
}