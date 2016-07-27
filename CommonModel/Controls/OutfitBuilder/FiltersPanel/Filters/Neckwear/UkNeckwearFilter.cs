using CommonModel.Controls.OutfitBuilder.FiltersPanel.Filters.Suits;
using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace CommonModel.Controls.OutfitBuilder.FiltersPanel.Filters.Neckwear
{
    public abstract class UkNeckwearFilter : BaseNeckwearFilter
    {
        protected UkNeckwearFilter(TestSettings testSettings) : base(testSettings)
        {
        }
        
        public ColourSelector ColourGrey
        {
            get { return new ColourSelector(Driver.FindElement(Container, Locators.ColourGrey)); }
        }

        public Selector RucheSelect
        {
            get { return new Selector(Driver.FindElement(Container, Locators.RucheSelect)); }
        }

        public new class Locators : BaseNeckwearFilter.Locators
        {
            public static readonly By ColourGrey = By.CssSelector("[data-colour-desc='Grey']");
            public static readonly By RucheSelect = By.CssSelector("[data-neckwear-typeid='1']");
        }
    }
}
