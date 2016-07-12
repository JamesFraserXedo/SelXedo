using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.Common.Header.NavigationSidebar
{
    public abstract class BaseNavigationSidebar : ControlBase
    {
        public BaseNavigationSidebar(TestSettings testSettings) : base(testSettings)
        {
        }

        public IWebElement Container
        {
            get { return Driver.FindElement(Locators.Container); }
        }

        public Button DismissSidebarButton
        {
            get { return new Button(Driver.FindElement(Container, Locators.DismissSidebarButton)); }
        }
        
        public Button HomeButton
        {
            get { return new Button(Driver.FindElement(Container, Locators.HomeButton)); }
        }

        public Button OutfitBuilderButton
        {
            get { return new Button(Driver.FindElement(Container, Locators.OutfitBuilderButton)); }
        }

        public Button ProfileButton
        {
            get { return new Button(Driver.FindElement(Container, Locators.ProfileButton)); }
        }

        public Button OrdersButton
        {
            get { return new Button(Driver.FindElement(Container, Locators.OrdersButton)); }
        }

        public Button OrdersCountLabel
        {
            get { return new Button(Driver.FindElement(Container, Locators.OrdersCountLabel)); }
        }

        public Button FavouritesButton
        {
            get { return new Button(Driver.FindElement(Container, Locators.FavouritesButton)); }
        }

        public Button FavouritesCountLabel
        {
            get { return new Button(Driver.FindElement(Container, Locators.FavouritesCountLabel)); }
        }

        public Button HowItWorksButton
        {
            get { return new Button(Driver.FindElement(Container, Locators.HowItWorksButton)); }
        }

        public Button PriceListButton
        {
            get { return new Button(Driver.FindElement(Container, Locators.PriceListButton)); }
        }

        public Button ContactUsButton
        {
            get { return new Button(Driver.FindElement(Container, Locators.ContactUsButton)); }
        }

        public class Locators
        {
            public static By Container = By.ClassName("menu-wrapper");
            public static By DismissSidebarButton = By.Id("nav-close-button");
            public static By HomeButton = By.CssSelector("[data-at='lnk-menu-home']");
            public static By OutfitBuilderButton = By.CssSelector("[data-at='lnk-menu-outfit-builder']");
            public static By ProfileButton = By.CssSelector("[data-at='lnk-menu-profile']");
            public static By OrdersButton = By.CssSelector("[data-at='lnk-menu-orders']");
            public static By OrdersCountLabel = By.CssSelector("[data-at='lnk-menu-orders']>span");
            public static By FavouritesButton = By.CssSelector("[data-at='lnk-menu-favourites']");
            public static By FavouritesCountLabel = By.CssSelector("[data-at='lnk-menu-favourites']>span");
            public static By HowItWorksButton = By.CssSelector("[data-at='lnk-menu-how-it-works']");
            public static By PriceListButton = By.CssSelector("[data-at='lnk-menu-pricelist']");
            public static By ContactUsButton = By.CssSelector("[data-at='lnk-menu-contact-us']");

        }
    }
}
