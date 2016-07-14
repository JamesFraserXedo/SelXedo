using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.OutfitBuilder.FiltersPanel.Filters.Shirts
{
    public abstract class BaseShirtFilter : BaseFilter
    {
        protected BaseShirtFilter(TestSettings testSettings) : base(testSettings)
        {
        }

        public override IWebElement Container
        {
            get { return Driver.FindElement(Locators.Container); }
        }

        public new class Locators : BaseFilter.Locators
        {
            public static readonly By Container = By.Id("filters-shirt");
        }
    }
}
