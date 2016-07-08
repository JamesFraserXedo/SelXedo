using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace TMLewinModel.Controls.OutfitBuilder.Filters
{
    public class AccessoriesFilter : ControlBase
    {
        public AccessoriesFilter(TestSettings testSettings) : base(testSettings)
        {
        }

        public IWebElement Container
        {
            get { return Driver.FindElement(Locators.Container); }
        }

        public IWebElement Title
        {
            get { return Driver.FindElement(Container, Locators.Title); }
        }

        public bool Completed
        {
            get { return Title.GetAttribute("class").Contains("complete"); }
        }

        public class Locators
        {
            public static By Container = By.Id("filters-accessories");
            public static By Title = By.CssSelector("[data-at='click-filter-Accessories']");
        }
    }
}
