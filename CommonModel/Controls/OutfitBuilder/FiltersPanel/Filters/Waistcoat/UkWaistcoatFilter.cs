using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.OutfitBuilder.FiltersPanel.Filters.Waistcoat
{
    public abstract class UkWaistcoatFilter : BaseWaistcoatFilter
    {
        protected UkWaistcoatFilter(TestSettings testSettings) : base(testSettings)
        {
        }

        public override IWebElement Container
        {
            get { return Driver.FindElement(Locators.Container); }
        }

        public ColourSelector ColourGrey
        {
            get { return new ColourSelector(Driver.FindElement(Container, Locators.ColourGrey)); }
        }

        public new class Locators : BaseWaistcoatFilter.Locators
        {
            public static By Container = By.Id("filters-waistcoat");
            public static By ColourGrey = By.CssSelector("[data-colour-desc='Grey']");
        }
    }
}
