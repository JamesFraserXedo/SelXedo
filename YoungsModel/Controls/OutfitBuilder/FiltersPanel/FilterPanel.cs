﻿using Core.Model.TestObjects.Bases;
using YoungsModel.Controls.OutfitBuilder.FiltersPanel.Filters;

namespace YoungsModel.Controls.OutfitBuilder.FiltersPanel
{
    public class FilterPanel : ControlBase
    {
        public FilterPanel(TestSettings testSettings) : base(testSettings)
        {
        }

        public SuitFilter SuitsFilter
        {
            get { return new SuitFilter(TestSettings); }
        }

        public NeckwearFilter NeckwearFilter
        {
            get { return new NeckwearFilter(TestSettings); }
        }

        public WaistcoatFilter WaistcoatsFilter
        {
            get { return new WaistcoatFilter(TestSettings); }
        }

        public ShirtsFilter ShirtsFilter
        {
            get { return new ShirtsFilter(TestSettings); }
        }

        public AccessoriesFilter AccessoriesFilter
        {
            get { return new AccessoriesFilter(TestSettings); }
        }
    }
}
