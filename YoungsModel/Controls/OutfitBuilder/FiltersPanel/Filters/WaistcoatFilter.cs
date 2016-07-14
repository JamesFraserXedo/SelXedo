using CommonModel.Controls.OutfitBuilder.FiltersPanel.Filters.Waistcoat;
using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace YoungsModel.Controls.OutfitBuilder.FiltersPanel.Filters
{
    public class WaistcoatFilter : UkWaistcoatFilter
    {
        public WaistcoatFilter(TestSettings testSettings) : base(testSettings)
        {
        }

        public ColourSelector ColourBrown
        {
            get { return new ColourSelector(Driver.FindElement(Container, Locators.ColourBrown)); }
        }

        public ColourSelector ColourRed
        {
            get { return new ColourSelector(Driver.FindElement(Container, Locators.ColourRed)); }
        }

        public ColourSelector ColourOrange
        {
            get { return new ColourSelector(Driver.FindElement(Container, Locators.ColourOrange)); }
        }

        public ColourSelector ColourYellow
        {
            get { return new ColourSelector(Driver.FindElement(Container, Locators.ColourYellow)); }
        }

        public ColourSelector ColourGreen
        {
            get { return new ColourSelector(Driver.FindElement(Container, Locators.ColourGreen)); }
        }

        public ColourSelector ColourTeal
        {
            get { return new ColourSelector(Driver.FindElement(Container, Locators.ColourTeal)); }
        }

        public ColourSelector ColourPurple
        {
            get { return new ColourSelector(Driver.FindElement(Container, Locators.ColourPurple)); }
        }
        
        public new class Locators : UkWaistcoatFilter.Locators
        {
            public static readonly By ColourBrown = By.CssSelector("[data-colour-desc='Brown']");
            public static readonly By ColourRed = By.CssSelector("[data-colour-desc='Red']");
            public static readonly By ColourOrange = By.CssSelector("[data-colour-desc='Orange']");
            public static readonly By ColourYellow = By.CssSelector("[data-colour-desc='Yellow']");
            public static readonly By ColourGreen = By.CssSelector("[data-colour-desc='Green']");
            public static readonly By ColourTeal = By.CssSelector("[data-colour-desc='Teal']");
            public static readonly By ColourPurple = By.CssSelector("[data-colour-desc='Purple']");
        }
    }
}
