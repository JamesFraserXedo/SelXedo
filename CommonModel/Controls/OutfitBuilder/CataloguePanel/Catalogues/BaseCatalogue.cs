using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.OutfitBuilder.CataloguePanel.Catalogues
{
    public abstract class BaseCatalogue : ControlBase
    {
        protected BaseCatalogue(TestSettings testSettings) : base(testSettings)
        {
        }

        public IWebElement Container
        {
            get { return Driver.FindElement(Locators.Container); }
        }

        public IWebElement Header
        {
            get { return Driver.FindElement(Container, Locators.Header); }
        }

        public class Locators
        {
            public static By Container = By.Id("catalogue-view");
            public static By Header = By.CssSelector("h2");
        }
    }
}
