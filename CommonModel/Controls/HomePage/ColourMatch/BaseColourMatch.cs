using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.HomePage.ColourMatch
{
    public abstract class BaseColourMatch : ControlBase
    {
        protected BaseColourMatch(TestSettings testSettings) : base(testSettings)
        {
        }

        protected IWebElement Container
        {
            get { return Driver.FindElement(Locators.Container); }
        }

        public Button Black
        {
            get { return new Button(Driver.FindElement(Container, Locators.Black)); }
        }

        public Button Teal
        {
            get { return new Button(Driver.FindElement(Container, Locators.Teal)); }
        }

        public Button Blue
        {
            get { return new Button(Driver.FindElement(Container, Locators.Blue)); }
        }

        public Button Green
        {
            get { return new Button(Driver.FindElement(Container, Locators.Green)); }
        }

        public Button Purple
        {
            get { return new Button(Driver.FindElement(Container, Locators.Purple)); }
        }

        public Button Red
        {
            get { return new Button(Driver.FindElement(Container, Locators.Red)); }
        }

        public Button Tan
        {
            get { return new Button(Driver.FindElement(Container, Locators.Tan)); }
        }

        public Button Pink
        {
            get { return new Button(Driver.FindElement(Container, Locators.Pink)); }
        }

        public Button Yellow
        {
            get { return new Button(Driver.FindElement(Container, Locators.Yellow)); }
        }

        public Button Ivory
        {
            get { return new Button(Driver.FindElement(Container, Locators.Ivory)); }
        }

        public class Locators
        {
            public static readonly By Container = By.CssSelector("[class='colour-match-item-wrap']");
            public static readonly By Black = By.CssSelector("[data-at='lnk-colour-match-black']");
            public static readonly By Teal = By.CssSelector("[data-at='lnk-colour-match-teal']");
            public static readonly By Blue = By.CssSelector("[data-at='lnk-colour-match-blue']");
            public static readonly By Green = By.CssSelector("[data-at='lnk-colour-match-green']");
            public static readonly By Purple = By.CssSelector("[data-at='lnk-colour-match-purple']");
            public static readonly By Gray = By.CssSelector("[data-at='lnk-colour-match-gray']");
            public static readonly By Red = By.CssSelector("[data-at='lnk-colour-match-red']");
            public static readonly By Tan = By.CssSelector("[data-at='lnk-colour-match-tan']");
            public static readonly By Pink = By.CssSelector("[data-at='lnk-colour-match-pink']");
            public static readonly By Yellow = By.CssSelector("[data-at='lnk-colour-match-yellow']");
            public static readonly By Ivory = By.CssSelector("[data-at='lnk-colour-match-ivory']");
        }
    }
}
