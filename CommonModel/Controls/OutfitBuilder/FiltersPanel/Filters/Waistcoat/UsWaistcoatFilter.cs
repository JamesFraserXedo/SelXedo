using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.OutfitBuilder.FiltersPanel.Filters.Waistcoat
{
    public abstract class UsWaistcoatFilter : BaseWaistcoatFilter
    {
        protected UsWaistcoatFilter(TestSettings testSettings) : base(testSettings)
        {
        }

        public override IWebElement Container
        {
            get { return Driver.FindElement(Locators.Container); }
        }

        public ColourSelector ColourTan
        {
            get { return new ColourSelector(Driver.FindElement(Container, Locators.ColourTan)); }
        }

        public ColourSelector ColourRed
        {
            get { return new ColourSelector(Driver.FindElement(Container, Locators.ColourRed)); }
        }

        public ColourSelector ColourYellow
        {
            get { return new ColourSelector(Driver.FindElement(Container, Locators.ColourYellow)); }
        }

        public ColourSelector ColourTeal
        {
            get { return new ColourSelector(Driver.FindElement(Container, Locators.ColourTeal)); }
        }

        public ColourSelector ColourPurple
        {
            get { return new ColourSelector(Driver.FindElement(Container, Locators.ColourPurple)); }
        }

        public ColourSelector ColourPink
        {
            get { return new ColourSelector(Driver.FindElement(Container, Locators.ColourPink)); }
        }

        public ColourSelector ColourWhite
        {
            get { return new ColourSelector(Driver.FindElement(Container, Locators.ColourWhite)); }
        }

        public ColourSelector ColourGray
        {
            get { return new ColourSelector(Driver.FindElement(Container, Locators.ColourGray)); }
        }

        public new class Locators : BaseWaistcoatFilter.Locators
        {
            public static readonly By Container = By.Id("filters-waistcoat-cummerbund");
            public static readonly By ColourTan = By.CssSelector("[data-colour-desc='Tan']");
            public static readonly By ColourRed = By.CssSelector("[data-colour-desc='Red']");
            public static readonly By ColourYellow = By.CssSelector("[data-colour-desc='Yellow']");
            public static readonly By ColourTeal = By.CssSelector("[data-colour-desc='Teal']");
            public static readonly By ColourPurple = By.CssSelector("[data-colour-desc='Purple']");
            public static readonly By ColourPink = By.CssSelector("[data-colour-desc='Pink']");
            public static readonly By ColourWhite = By.CssSelector("[data-colour-desc='White']");
            public static readonly By ColourGray = By.CssSelector("[data-colour-desc='Gray']");
        }
    }
}
