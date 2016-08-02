using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.Common.Header
{
    public abstract class BaseHeader : ControlBase
    {
        protected BaseHeader(TestSettings testSettings) : base(testSettings)
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

        public int OrdersCount
        {
            get { return int.Parse(OrdersCountLabel.Text); }
        }

        public int FavouritesCount
        {
            get { return int.Parse(FavouritesCountLabel.Text); }
        }

        public class Locators
        {
            public static readonly By SignInButton = By.CssSelector("[data-at='lnk-header-signin']");
            public static readonly By NameLabel = By.CssSelector("[class='person-id']");
            public static readonly By OrdersLink = By.CssSelector("[data-at='lnk-header-orders']");
            public static readonly By OrdersCountLabel = By.CssSelector("[data-at='lnk-header-orders']>span");
            public static readonly By FavouritesLink = By.CssSelector("[data-at='lnk-header-favourites']");
            public static readonly By FavouritesCountLabel = By.CssSelector("[data-at='lnk-header-favourites']>span");
            public static readonly By LogoutLink = By.CssSelector("[data-at='lnk-header-logout']");
        }
    }
}
