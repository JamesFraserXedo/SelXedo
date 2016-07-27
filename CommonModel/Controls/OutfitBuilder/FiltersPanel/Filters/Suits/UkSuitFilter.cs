using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace CommonModel.Controls.OutfitBuilder.FiltersPanel.Filters.Suits
{
    public abstract class UkSuitFilter : BaseSuitsFilter
    {
        protected UkSuitFilter(TestSettings testSettings) : base(testSettings)
        {
        }

        public ColourSelector ColourBlack
        {
            get { return new ColourSelector(Driver.FindElement(Container, Locators.ColourBlack)); }
        }

        public ColourSelector ColourBlue
        {
            get { return new ColourSelector(Driver.FindElement(Container, Locators.ColourBlue)); }
        }

        public ColourSelector ColourGrey
        {
            get { return new ColourSelector(Driver.FindElement(Container, Locators.ColourGray)); }
        }

        public Selector TailcoatSelect
        {
            get { return new Selector(Driver.FindElement(Container, Locators.TailcoatSelect)); }
        }

        public Selector ShortJacketSelect
        {
            get { return new Selector(Driver.FindElement(Container, Locators.ShortJacketSelect)); }
        }

        public new class Locators : BaseSuitsFilter.Locators
        {
            public static readonly By ColourBlack = By.CssSelector("[data-colour-desc='Black']");
            public static readonly By ColourBlue = By.CssSelector("[data-colour-desc='Blue']");
            public static readonly By ColourGray = By.CssSelector("[data-colour-desc='Grey']");
            public static readonly By TailcoatSelect = By.CssSelector("[value='Tailcoat']");
            public static readonly By ShortJacketSelect = By.CssSelector("[value='Short Jacket']");
        }
    }
}
