using Core.CustomElements;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.Common.Header
{
    public class BaseHeader : ControlBase
    {
        public BaseHeader(TestSettings testSettings) : base(testSettings)
        {
        }

        public Button SignInButton
        {
            get { return new Button(Driver.FindElement(Locators.SignInButton)); }
        }

        public Link NameLabel
        {
            get { return new Link(Driver.FindElement(Locators.NameLabel)); }
        }

        public Link OrdersLink
        {
            get { return new Link(Driver.FindElement(Locators.OrdersLink)); }
        }

        public Link OrdersCountLabel
        {
            get { return new Link(Driver.FindElement(Locators.OrdersCountLabel)); }
        }

        public Link FavouritesLink
        {
            get { return new Link(Driver.FindElement(Locators.FavouritesLink)); }
        }

        public Link FavouritesCountLabel
        {
            get { return new Link(Driver.FindElement(Locators.FavouritesCountLabel)); }
        }

        public Link LogoutLink
        {
            get { return new Link(Driver.FindElement(Locators.LogoutLink)); }
        }

        public class Locators
        {
            public static By SignInButton = By.CssSelector("[data-at='lnk-header-signin']");
            public static By NameLabel = By.CssSelector("[class='person-id']");
            public static By OrdersLink = By.CssSelector("[data-at='lnk-header-orders']");
            public static By OrdersCountLabel = By.CssSelector("[data-at='lnk-header-orders']>span");
            public static By FavouritesLink = By.CssSelector("[data-at='lnk-header-favourites']");
            public static By FavouritesCountLabel = By.CssSelector("[data-at='lnk-header-favourites']>span");
            public static By LogoutLink = By.CssSelector("[data-at='lnk-header-logout']");
        }
    }
}
