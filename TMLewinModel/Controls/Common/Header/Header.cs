using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace TMLewinModel.Controls.Common.Header
{
    public class Header : ControlBase
    {
        public Header(TestSettings testSettings) : base(testSettings) {
            
        }

        public IWebElement Container
        {
            get { return Driver.FindElement(Locators.Container); }
        }

        public IWebElement Logo
        {
            get { return Driver.FindElement(Container, Locators.Logo); }
        }

        public IWebElement ReturnToMainSiteLink
        {
            get { return Driver.FindElement(Container, Locators.ReturnToMainSiteLink); }
        }

        public Button ToggleNavSidebarButton
        {
            get { return new Button(Driver.FindElement(Container, Locators.ToggleNavSidebarButton)); }
        }

        public Button ToggleLoginSidebarButton
        {
            get { return new Button(Driver.FindElement(Container, Locators.ToggleLoginSidebarButton)); }
        }

        public IWebElement LoggedInUserNameLabel
        {
            get { return Driver.FindElement(Container, Locators.LoggedInUserNameLabel); }
        }

        public Button OrdersButton
        {
            get { return new Button(Driver.FindElement(Container, Locators.OrdersButton)); }
        }

        public IWebElement OrdersCountLabel
        {
            get { return Driver.FindElement(Container, Locators.OrdersCountLabel); }
        }

        public Button FavouritesButton
        {
            get { return new Button(Driver.FindElement(Container, Locators.FavouritesButton)); }
        }

        public IWebElement FavouritesCountLabel
        {
            get { return Driver.FindElement(Container, Locators.FavouritesCountLabel); }
        }

        public IWebElement LogoutLink
        {
            get { return Driver.FindElement(Container, Locators.LogoutButton); }
        }

        public IWebElement FreeDeliveryAndReturnsBanner
        {
            get { return Driver.FindElement(Container, Locators.FreeDeliveryAndReturnsBanner); }
        }
        
        public class Locators
        {
            public static By Container = By.CssSelector("[class='container nav-holder']");
            public static By Logo = By.CssSelector("[alt='header image']");
            public static By ReturnToMainSiteLink = By.CssSelector("[title='Return to the main TM Lewin site']");
            public static By ToggleNavSidebarButton = By.Id("open-button");
            public static By ToggleLoginSidebarButton = By.CssSelector("[data-at='lnk-header-signin']");
            
            public static By LoggedInUserNameLabel = By.CssSelector("[class='person-id']");
            public static By OrdersButton = By.CssSelector("[data-at='lnk-header-orders']");
            public static By OrdersCountLabel = By.CssSelector("[data-at='lnk-header-orders']>.signin-button-numbers");
            public static By FavouritesButton = By.CssSelector("[data-at='lnk-header-favourites']");
            public static By FavouritesCountLabel = By.CssSelector("[data-at='lnk-header-favourites']>.signin-button-numbers");
            public static By LogoutButton = By.CssSelector("[data-at='lnk-header-logout']");

            public static By FreeDeliveryAndReturnsBanner = By.CssSelector("[class='free-try-on-message']");
        }
    }
}
