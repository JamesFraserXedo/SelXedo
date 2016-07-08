using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace TMLewinModel.Controls.OutfitBuilder.Filters
{
    public class WaistcoatsFilter : ControlBase
    {
        public WaistcoatsFilter(TestSettings testSettings) : base(testSettings)
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

        public IWebElement Body
        {
            get { return Driver.FindElement(Container, Locators.Body); }
        }

        public Colour ColourPaletteBlack
        {
            get { return new Colour(TestSettings, Driver.FindElement(Container, Locators.ColourPaletteBlack)); }
        }

        public Colour ColourPaletteCream
        {
            get { return new Colour(TestSettings, Driver.FindElement(Container, Locators.ColourPaletteCream)); }
        }

        public Colour ColourPaletteBlue
        {
            get { return new Colour(TestSettings, Driver.FindElement(Container, Locators.ColourPaletteBlue)); }
        }

        public Colour ColourPaletteGrey
        {
            get { return new Colour(TestSettings, Driver.FindElement(Container, Locators.ColourPaletteGrey)); }
        }
        
        public bool Completed
        {
            get { return Title.GetAttribute("class").Contains("complete"); }
        }

        public bool Expanded
        {
            get { return Driver.ElementDisplayed(Container, Locators.Body); }
        }

        public class Locators
        {
            public static By Container = By.Id("filters-waistcoat");
            public static By Title = By.CssSelector("[data-at='click-filter-Waistcoat']");
            public static By Body = By.ClassName("filters-section-body");

            public static By ColourPaletteBlack = By.CssSelector("[data-colour-desc='Black']");
            public static By ColourPaletteCream = By.CssSelector("[data-colour-desc='Cream']");
            public static By ColourPaletteBlue = By.CssSelector("[data-colour-desc='Blue']");
            public static By ColourPaletteGrey = By.CssSelector("[data-colour-desc='Grey']");
        }
    }
}
