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
            get { Driver.FindElement(Locators.Container); }
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
            public static By Container = By.Id("filters-waistcoat-cummerbund");
            public static By ColourTan = By.CssSelector("[data-colour-desc='Tan']");
            public static By ColourRed = By.CssSelector("[data-colour-desc='Red']");
            public static By ColourYellow = By.CssSelector("[data-colour-desc='Yellow']");
            public static By ColourTeal = By.CssSelector("[data-colour-desc='Teal']");
            public static By ColourPurple = By.CssSelector("[data-colour-desc='Purple']");
            public static By ColourPink = By.CssSelector("[data-colour-desc='Pink']");
            public static By ColourWhite = By.CssSelector("[data-colour-desc='White']");
            public static By ColourGray = By.CssSelector("[data-colour-desc='Gray']");
        }
    }
}
