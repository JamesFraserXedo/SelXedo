using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace TMLewinModel.Controls.OutfitBuilder.Filters
{
    public class SuitsFilter : ControlBase
    {
        public SuitsFilter(TestSettings testSettings) : base(testSettings)
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

        public Colour ColourPaletteBlue
        {
            get { return new Colour(TestSettings, Driver.FindElement(Container, Locators.ColourPaletteBlue)); }
        }

        public Colour ColourPaletteGrey
        {
            get { return new Colour(TestSettings, Driver.FindElement(Container, Locators.ColourPaletteGrey)); }
        }

        public Checkbox TailcoatCheckbox
        {
            get { return new Checkbox(Driver.FindElement(Container, Locators.TailcoatCheckbox)); }
        }

        public Checkbox ShortJacketCheckbox
        {
            get { return new Checkbox(Driver.FindElement(Container, Locators.ShortJacketCheckbox)); }
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
            public static By Container = By.Id("filters-suits");
            public static By Title = By.CssSelector("[data-at='click-filter-Jacket']");
            public static By Body = By.ClassName("filters-section-body");

            public static By ColourPaletteBlack = By.CssSelector("[data-colour-desc='Black']");
            public static By ColourPaletteBlue = By.CssSelector("[data-colour-desc='Blue']");
            public static By ColourPaletteGrey = By.CssSelector("[data-colour-desc='Grey']");

            public static By TailcoatCheckbox = By.CssSelector("[value='Tailcoat']");
            public static By ShortJacketCheckbox = By.CssSelector("[value='Short Jacket']");
        }
    }
}
