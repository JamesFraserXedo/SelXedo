using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.OutfitBuilder.FiltersPanel.Filters.Suits
{
    public abstract class BaseSuitsFilter : BaseExpandableFilter
    {
        protected BaseSuitsFilter(TestSettings testSettings) : base(testSettings)
        {
        }

        public override IWebElement Container
        {
            get { return Driver.FindElement(Locators.Container); }
        }

        public new class Locators : BaseExpandableFilter.Locators
        {
            public static readonly By Container = By.Id("filters-suits");
        }
    }
}
