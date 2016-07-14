using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.OutfitBuilder.FiltersPanel.Filters.Suits
{
    public abstract class UsSuitFilter : BaseSuitsFilter
    {
        protected UsSuitFilter(TestSettings testSettings) : base(testSettings)
        {
        }

        public ColourSelector ColourBlack
        {
            get { return new ColourSelector(Driver.FindElement(Container, Locators.ColourBlack)); }
        }

        public ColourSelector ColourTan
        {
            get { return new ColourSelector(Driver.FindElement(Container, Locators.ColourTan)); }
        }

        public ColourSelector ColourBlue
        {
            get { return new ColourSelector(Driver.FindElement(Container, Locators.ColourBlue)); }
        }

        public ColourSelector ColourGray
        {
            get { return new ColourSelector(Driver.FindElement(Container, Locators.ColourGray)); }
        }

        public new class Locators : BaseSuitsFilter.Locators
        {
            public static readonly By ColourBlack = By.CssSelector("[data-colour-desc='Black']");
            public static readonly By ColourTan = By.CssSelector("[data-colour-desc='Tan']");
            public static readonly By ColourBlue = By.CssSelector("[data-colour-desc='Blue']");
            public static readonly By ColourGray = By.CssSelector("[data-colour-desc='Gray']");
        }
    }
}
