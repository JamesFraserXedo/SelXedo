using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.OutfitBuilder.FiltersPanel.Filters.Accessories
{
    public abstract class BaseAccessoriesFilter : BaseFilter
    {
        protected BaseAccessoriesFilter(TestSettings testSettings) : base(testSettings)
        {
        }

        public override IWebElement Container
        {
            get { return Driver.FindElement(Locators.Container); }
        }

        public new class Locators : BaseFilter.Locators
        {
            public static By Container = By.Id("filters-accessories");
        }
    }
}
