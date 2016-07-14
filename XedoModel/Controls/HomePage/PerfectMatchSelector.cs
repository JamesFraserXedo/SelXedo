using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace XedoModel.Controls.HomePage
{
    public class PerfectMatchSelector : ControlBase
    {
        public PerfectMatchSelector(TestSettings testSettings) : base(testSettings)
        {
        }

        public IWebElement Container
        {
            get { return Driver.FindElement(Locators.Container); }
        }

        public IWebElement Black
        {
            get { return Driver.FindElement(Container, Locators.Black); }
        }

        public IWebElement Teal
        {
            get { return Driver.FindElement(Container, Locators.Teal); }
        }

        public IWebElement Blue
        {
            get { return Driver.FindElement(Container, Locators.Blue); }
        }

        public IWebElement Green
        {
            get { return Driver.FindElement(Container, Locators.Green); }
        }

        public IWebElement Purple
        {
            get { return Driver.FindElement(Container, Locators.Purple); }
        }

        public IWebElement Grey
        {
            get { return Driver.FindElement(Container, Locators.Grey); }
        }

        public IWebElement Red
        {
            get { return Driver.FindElement(Container, Locators.Red); }
        }

        public IWebElement Tan
        {
            get { return Driver.FindElement(Container, Locators.Tan); }
        }

        public IWebElement Pink
        {
            get { return Driver.FindElement(Container, Locators.Pink); }
        }

        public IWebElement Yellow
        {
            get { return Driver.FindElement(Container, Locators.Yellow); }
        }

        public IWebElement Ivory
        {
            get { return Driver.FindElement(Container, Locators.Ivory); }
        }

        public class Locators
        {
            public static readonly By Container = By.Id("perfect-match");
            public static readonly By Black = By.CssSelector("[data-at='lnk-colour-match-black']");
            public static readonly By Teal = By.CssSelector("[data-at='lnk-colour-match-teal']");
            public static readonly By Blue = By.CssSelector("[data-at='lnk-colour-match-blue']");
            public static readonly By Green = By.CssSelector("[data-at='lnk-colour-match-green']");
            public static readonly By Purple = By.CssSelector("[data-at='lnk-colour-match-purple']");
            public static readonly By Grey = By.CssSelector("[data-at='lnk-colour-match-gray']");
            public static readonly By Red = By.CssSelector("[data-at='lnk-colour-match-red']");
            public static readonly By Tan = By.CssSelector("[data-at='lnk-colour-match-tan']");
            public static readonly By Pink = By.CssSelector("[data-at='lnk-colour-match-pink']");
            public static readonly By Yellow = By.CssSelector("[data-at='lnk-colour-match-yellow']");
            public static readonly By Ivory = By.CssSelector("[data-at='lnk-colour-match-ivory']");

        }
    }
}
