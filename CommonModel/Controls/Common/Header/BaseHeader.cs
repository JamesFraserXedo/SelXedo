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

        public Link Name
        {
            get { return new Link(Driver.FindElement(Locators.Name)); }
        }

        public Link Orders
        {
            get { return new Link(Driver.FindElement(Locators.Orders)); }
        }

        public Link OrdersCount
        {
            get { return new Link(Driver.FindElement(Locators.OrdersCount)); }
        }

        public Link Favourites
        {
            get { return new Link(Driver.FindElement(Locators.Favourites)); }
        }

        public Link FavouritesCount
        {
            get { return new Link(Driver.FindElement(Locators.FavouritesCount)); }
        }

        public Link Logout
        {
            get { return new Link(Driver.FindElement(Locators.Logout)); }
        }

        public class Locators
        {
            public static By SignInButton = By.CssSelector("[data-at='lnk-header-signin']");
            public static By Name = By.CssSelector("[class='person-id']");
            public static By Orders = By.CssSelector("[data-at='lnk-header-orders']");
            public static By OrdersCount = By.CssSelector("[data-at='lnk-header-orders']>span");
            public static By Favourites = By.CssSelector("[data-at='lnk-header-favourites']");
            public static By FavouritesCount = By.CssSelector("[data-at='lnk-header-favourites']>span");
            public static By Logout = By.CssSelector("[data-at='lnk-header-logout']");
        }
    }
}
