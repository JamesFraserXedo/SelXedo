using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.OutfitBuilder.FiltersPanel.Filters.Waistcoat
{
    public abstract class BaseWaistcoatFilter : BaseExpandableFilter
    {
        protected BaseWaistcoatFilter(TestSettings testSettings) : base(testSettings)
        {
        }

        public ColourSelector ColourBlack
        {
            get { return new ColourSelector(Driver.FindElement(Container, Locators.ColourBlack)); }
        }

        public ColourSelector ColourCream
        {
            get { return new ColourSelector(Driver.FindElement(Container, Locators.ColourCream)); }
        }

        public ColourSelector ColourBlue
        {
            get { return new ColourSelector(Driver.FindElement(Container, Locators.ColourBlue)); }
        }

        public new class Locators : BaseExpandableFilter.Locators
        {
            public static By ColourBlack = By.CssSelector("[data-colour-desc='Black']");
            public static By ColourCream = By.CssSelector("[data-colour-desc='Cream']");
            public static By ColourBlue = By.CssSelector("[data-colour-desc='Blue']");
        }
    }
}
