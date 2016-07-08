using System.Threading;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;
using XedoModel.Controls.OutfitBuilder.Filters.Colour;

namespace XedoModel.Controls.OutfitBuilder.Filters
{
    public abstract class ExpandableFilterBase : FilterBase
    {
        protected ExpandableFilterBase(TestSettings testSettings) : base(testSettings)
        {
        }
        
        public ColourFilter ColourFilter
        {
            get { return new ColourFilter(TestSettings, Container); }
        }

        public void Expand()
        {
            if (!Expanded)
            {
                HeadingContainer.Click();
                Thread.Sleep(500);
            }
        }

        public void Close()
        {
            if (Expanded)
            {
                HeadingContainer.Click();
            }
        }

        public new void SetActive()
        {
            Expand();
        }
        

        public new class Locators : FilterBase.Locators
        {
            public new static By BodyContainer = By.XPath("/nav");
            public static By ColourFilters = By.Id("filters-styles");
            public static By StyleFiltersPanel = By.Id("filters-pane-style");
            public static By StyleFilters = By.Id("filters-styles");
        }
    }
}