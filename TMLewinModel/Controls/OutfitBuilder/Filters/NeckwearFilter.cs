using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace TMLewinModel.Controls.OutfitBuilder.Filters
{
    public class NeckwearFilter : ControlBase
    {
        public NeckwearFilter(TestSettings testSettings) : base(testSettings)
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

        public Colour ColourPaletteBrown
        {
            get { return new Colour(TestSettings, Driver.FindElement(Container, Locators.ColourPaletteBrown)); }
        }

        public Colour ColourPaletteRed
        {
            get { return new Colour(TestSettings, Driver.FindElement(Container, Locators.ColourPaletteRed)); }
        }

        public Colour ColourPaletteOrange
        {
            get { return new Colour(TestSettings, Driver.FindElement(Container, Locators.ColourPaletteOrange)); }
        }

        public Colour ColourPaletteCream
        {
            get { return new Colour(TestSettings, Driver.FindElement(Container, Locators.ColourPaletteCream)); }
        }

        public Colour ColourPaletteYellow
        {
            get { return new Colour(TestSettings, Driver.FindElement(Container, Locators.ColourPaletteYellow)); }
        }

        public Colour ColourPaletteGreen
        {
            get { return new Colour(TestSettings, Driver.FindElement(Container, Locators.ColourPaletteGreen)); }
        }

        public Colour ColourPaletteBlue
        {
            get { return new Colour(TestSettings, Driver.FindElement(Container, Locators.ColourPaletteBlue)); }
        }

        public Colour ColourPalettePurple
        {
            get { return new Colour(TestSettings, Driver.FindElement(Container, Locators.ColourPalettePurple)); }
        }

        public Colour ColourPalettePink
        {
            get { return new Colour(TestSettings, Driver.FindElement(Container, Locators.ColourPalettePink)); }
        }

        public Colour ColourPaletteGrey
        {
            get { return new Colour(TestSettings, Driver.FindElement(Container, Locators.ColourPaletteGrey)); }
        }

        public Checkbox TieCheckbox
        {
            get { return new Checkbox(Driver.FindElement(Container, Locators.TieCheckbox)); }
        }

        public Checkbox RucheCheckbox
        {
            get { return new Checkbox(Driver.FindElement(Container, Locators.RucheCheckbox)); }
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
            public static By Container = By.Id("filters-neckwear");
            public static By Title = By.CssSelector("[data-at='click-filter-Neckwear']");
            public static By Body = By.ClassName("filters-section-body");

            public static By ColourPaletteBlack = By.CssSelector("[data-colour-desc='Black']");
            public static By ColourPaletteBrown = By.CssSelector("[data-colour-desc='Brown']");
            public static By ColourPaletteRed = By.CssSelector("[data-colour-desc='Red']");
            public static By ColourPaletteOrange = By.CssSelector("[data-colour-desc='Orange']");
            public static By ColourPaletteCream = By.CssSelector("[data-colour-desc='Cream']");
            public static By ColourPaletteYellow = By.CssSelector("[data-colour-desc='Yellow']");
            public static By ColourPaletteGreen = By.CssSelector("[data-colour-desc='Green']");
            public static By ColourPaletteBlue = By.CssSelector("[data-colour-desc='Blue']");
            public static By ColourPalettePurple = By.CssSelector("[data-colour-desc='Purple']");
            public static By ColourPalettePink = By.CssSelector("[data-colour-desc='Pink']");
            public static By ColourPaletteGrey = By.CssSelector("[data-colour-desc='Grey']");

            public static By TieCheckbox = By.CssSelector("[data-neckwear-typeid='2']");
            public static By RucheCheckbox = By.CssSelector("[data-neckwear-typeid='1']");
        }
    }
}
