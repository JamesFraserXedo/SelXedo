using Core.CustomElements;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.Common.Header
{
    public abstract class MenuHeader : BaseHeader
    {
        public MenuHeader(TestSettings testSettings) : base(testSettings)
        {
        }

        public Button LargeLogo
        {
            get { return new Button(Driver.FindElement(Locators.LargeLogo)); }
        }

        public Button SmallLogo
        {
            get { return new Button(Driver.FindElement(Locators.SmallLogo)); }
        }

        public Link HowItWorksLink
        {
            get { return new Link(Driver.FindElement(Locators.HowItWorksLink)); }
        }

        public Link InspireMeLink
        {
            get { return new Link(Driver.FindElement(Locators.InspireMeLink)); }
        }

        public Link CreateYourLookLink
        {
            get { return new Link(Driver.FindElement(Locators.CreateYourLookLink)); }
        }

        public new class Locators : BaseHeader.Locators
        {
            public static By LargeLogo = By.ClassName("main-logo");
            public static By SmallLogo = By.CssSelector("[data-at='lnk-menu-home']");
            public static By HowItWorksLink = By.CssSelector("[data-at='lnk-menu-how-it-works']");
            public static By InspireMeLink = By.CssSelector("[data-at='lnk-menu-inspired']");
            public static By CreateYourLookLink = By.CssSelector("[data-at='lnk-menu-outfit-builder']");

        }
    }
}
