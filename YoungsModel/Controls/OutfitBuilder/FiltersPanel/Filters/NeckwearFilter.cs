using CommonModel.Controls.OutfitBuilder.FiltersPanel.Filters.Neckwear;
using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace YoungsModel.Controls.OutfitBuilder.FiltersPanel.Filters
{
    public class NeckwearFilter : UkNeckwearFilter
    {
        public NeckwearFilter(TestSettings testSettings) : base(testSettings)
        {
        }

        public ColourSelector ColourTeal
        {
            get {return new ColourSelector(Driver.FindElement(Container, Locators.ColourTeal));}
        }

        public new class Locators : UkNeckwearFilter.Locators
        {
            public static By ColourTeal = By.CssSelector("[data-colour-desc='Teal']");
        }
    }
}
