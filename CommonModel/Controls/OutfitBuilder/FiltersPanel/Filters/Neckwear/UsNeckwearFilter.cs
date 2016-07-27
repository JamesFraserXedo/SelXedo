using CommonModel.Controls.OutfitBuilder.FiltersPanel.Filters.Suits;
using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace CommonModel.Controls.OutfitBuilder.FiltersPanel.Filters.Neckwear
{
    public abstract class UsNeckwearFilter : BaseNeckwearFilter
    {
        protected UsNeckwearFilter(TestSettings testSettings) : base(testSettings)
        {
        }
        
        public ColourSelector ColourTan
        {
            get { return new ColourSelector(Driver.FindElement(Container, Locators.ColourTan)); }
        }

        public ColourSelector ColourTeal
        {
            get { return new ColourSelector(Driver.FindElement(Container, Locators.ColourTeal)); }
        }

        public ColourSelector ColourWhite
        {
            get { return new ColourSelector(Driver.FindElement(Container, Locators.ColourWhite)); }
        }

        public ColourSelector ColourGray
        {
            get { return new ColourSelector(Driver.FindElement(Container, Locators.ColourGray)); }
        }
        
        public Selector BowTieSelect
        {
            get { return new Selector(Driver.FindElement(Container, Locators.BowTieSelect)); }
        }

        public new class Locators : BaseNeckwearFilter.Locators
        {
            public static readonly By ColourTan = By.CssSelector("[data-colour-desc='Tan']");
            public static readonly By ColourTeal = By.CssSelector("[data-colour-desc='Teal']");
            public static readonly By ColourWhite = By.CssSelector("[data-colour-desc='White']");
            public static readonly By ColourGray = By.CssSelector("[data-colour-desc='Gray']");
            public static readonly By BowTieSelect = By.CssSelector("[data-neckwear-typeid='3']");
        }
    }
}
