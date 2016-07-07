using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace Core.Controls.OutfitBuilder.Filters
{
    public class WaistcoatFilter : ExpandableFilterBase
    {
        public WaistcoatFilter(TestSettings testSettings) : base(testSettings)
        {
            FilterBase.Locators.Container = By.Id("filters-waistcoat-cummerbund");
            SetActive();
        }
    }
}