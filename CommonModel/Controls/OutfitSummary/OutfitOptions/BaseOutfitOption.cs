using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.OutfitSummary.OutfitOptions
{
    public abstract class BaseOutfitOption : ControlBase
    {
        protected BaseOutfitOption(TestSettings testSettings) : base(testSettings)
        {
        }

        public IWebElement Container {
            get { return Driver.FindElement(Locators.Container); }
        }

        public IWebElement SummaryPane
        {
            get { return Driver.FindElement(Container, Locators.SummaryPane); }
        }

        public IWebElement ContentPane
        {
            get { return Driver.FindElement(Container, Locators.ContentPane); }
        }
        
        public string Category
        {
            get { return Driver.FindElement(SummaryPane, Locators.CategoryLabel).Text; }
        }

        public string Name
        {
            get { return Driver.FindElement(SummaryPane, Locators.NameLabel).Text; }
        }

        public string Price
        {
            get { return Driver.FindElement(SummaryPane, Locators.PriceLabel).Text; }
        }

        public Button EditButton
        {
            get { return new Button(Driver.FindElement(SummaryPane, Locators.EditButton)); }
        }

        public bool Selected
        {
            get { return !Driver.ElementDisplayed(Locators.NotSelectedLabel); }
        }

        public void Expand()
        {
            Container.Click();
        }

        public class Locators
        {
            public static readonly By Container;
            public static readonly By SummaryPane = By.CssSelector("[class='outfit-summary-header']");
            public static readonly By ContentPane = By.CssSelector("[class='outfit-selection-content']");
            public static readonly By CategoryLabel = By.CssSelector("[class='details']>h2");
            public static readonly By NameLabel = By.CssSelector("[class='details']>p");
            public static readonly By PriceLabel = By.CssSelector("[class='componentPriceValue']");
            public static readonly By EditButton = By.CssSelector("[class='product-type-edit ga-event-click']");
            public static readonly By NotSelectedLabel = By.CssSelector("[class='none-selected']");
        }
    }
}
