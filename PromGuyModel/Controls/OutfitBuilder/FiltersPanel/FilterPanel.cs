﻿using CommonModel.Controls.OutfitBuilder.FiltersPanel;
using CommonModel.Controls.OutfitBuilder.FiltersPanel.Filters.Suits;
using Core.Model.TestObjects.Bases;
using PromGuyModel.Controls.OutfitBuilder.FiltersPanel.Filters;

namespace PromGuyModel.Controls.OutfitBuilder.FiltersPanel
{
    public class FilterPanel : BaseFilterPanel
    {
        public FilterPanel(TestSettings testSettings) : base(testSettings)
        {
        }

        public override BaseSuitsFilter SuitsFilter
        {
            get { return new SuitFilter(TestSettings); }
        }
    }
}
