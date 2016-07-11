using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;
using TMLewinModel.Controls.OutfitBuilder.Filters;

namespace TMLewinModel.Controls.OutfitBuilder
{
    public class CataloguePanel : ControlBase
    {
        public CataloguePanel(TestSettings testSettings) : base(testSettings)
        {
        }

        public SuitsFilter SuitsFilter
        {
            get { return new SuitsFilter(TestSettings); }
        }

        public NeckwearFilter NeckwearFilter
        {
            get { return new NeckwearFilter(TestSettings); }
        }

        public WaistcoatsFilter WaistcoatsFilter
        {
            get { return new WaistcoatsFilter(TestSettings); }
        }

        public ShirtsFilter ShirtsFilter
        {
            get { return new ShirtsFilter(TestSettings); }
        }

        public AccessoriesFilter AccessoriesFilter
        {
            get { return new AccessoriesFilter(TestSettings); }
        }

        public IWebElement Container
        {
            get { return Driver.FindElement(Locators.Container); }
        }

        public IWebElement ViewOutfitSummaryButton
        {
            get { return Driver.FindElement(Container, Locators.ViewOutfitSummaryButton); }
        }

        public IWebElement PreviousCatalogueButton
        {
            get { return Driver.FindElement(Container, Locators.PreviousCatalogueButton); }
        }

        public IWebElement NextCatalogueButton
        {
            get { return Driver.FindElement(Container, Locators.NextCatalogueButton); }
        }

        public class Locators
        {
            public static By Container = By.ClassName("catalogue-outfit-holder");
            public static By ViewOutfitSummaryButton = By.CssSelector("[data-at='lnk-outfit-summary']");
            public static By PreviousCatalogueButton = By.ClassName("ob-arrow left");
            public static By NextCatalogueButton = By.ClassName("ob-arrow right");
        }
    }
}
