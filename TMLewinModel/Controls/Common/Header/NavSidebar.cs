using System;
using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace TMLewinModel.Controls.Common.Header
{
    public class NavSidebar : ControlBase
    {
        private Header Header;

        public NavSidebar(TestSettings testSettings) : base(testSettings)
        {
            Header = new Header(testSettings);
        }

        public IWebElement Container
        {
            get { return Driver.FindElement(Locators.Container); }
        }

        public Button DismissButton
        {
            get { return new Button(Driver.FindElement(Container, Locators.DismissButton)); }
        }

        public Button HomeLink
        {
            get { return new Button(Driver.FindElement(Container, Locators.HomeLink)); }
        }

        public Button OutfitBuilderLink
        {
            get { return new Button(Driver.FindElement(Container, Locators.OutfitBuilderLink)); }
        }

        public Button HowItWorksLink
        {
            get { return new Button(Driver.FindElement(Container, Locators.HowItWorksLink)); }
        }

        public Button FreeDeliveryAndReturnsLink
        {
            get { return new Button(Driver.FindElement(Container, Locators.FreeDeliveryAndReturnsLink)); }
        }

        public Button PriceListLink
        {
            get { return new Button(Driver.FindElement(Container, Locators.PriceListLink)); }
        }

        public Button ContactUsLink
        {
            get { return new Button(Driver.FindElement(Container, Locators.ContactUsLink)); }
        }

        public Button ProfileLink
        {
            get { return new Button(Driver.FindElement(Container, Locators.ProfileLink)); }
        }

        public Button OrdersLink
        {
            get { return new Button(Driver.FindElement(Container, Locators.OrdersLink)); }
        }

        public Link ContactUsLink
        {
            get { return new Link(Driver.FindElement(Container, Locators.ContactUsLink)); }
        }

        public IWebElement OrdersCountLabel
        {
            get { return Driver.FindElement(Container, Locators.OrdersCountLabel); }
        }

        public Button FavouritesLink
        {
            get { return new Button(Driver.FindElement(Container, Locators.FavouritesLink)); }
        }

        public IWebElement FavouritesCountLabel
        {
            get { return Driver.FindElement(Container, Locators.FavouritesCountLabel); }
        }

        public int OrdersCount
        {
            get { return Int32.Parse(OrdersCountLabel.Text); }
        }

        public int FavouritesCount
        {
            get { return Int32.Parse(FavouritesCountLabel.Text); }
        }

        public bool Expanded
        {
            get { return Driver.ElementDisplayed(Locators.Container); }
        }

        public void Expand()
        {
            if (Expanded)
            {
                return;
            }
            Header.ToggleNavSidebarButton.Click();
        }

        public void Close()
        {
            if (!Expanded)
            {
                return;
            }
            DismissButton.Click();
        }

        public class Locators
        {
            public static By Container = By.CssSelector("[class='menu-wrapper']");
            public static By DismissButton = By.Id("nav-close-button");

            public static By HomeLink = By.CssSelector("[data-at='lnk-menu-home']");
            public static By OutfitBuilderLink = By.CssSelector("[data-at='lnk-menu-outfit-builder']");
            public static By HowItWorksLink = By.CssSelector("[data-at='lnk-menu-how-it-works']");
            public static By FreeDeliveryAndReturnsLink = By.CssSelector("[data-at='lnk-menu-freedelivery']");
            public static By PriceListLink = By.CssSelector("[data-at='lnk-menu-pricelist']");
            public static By ContactUsLink = By.CssSelector("[data-at='lnk-menu-contact-us']");

            public static By ProfileLink = By.CssSelector("[data-at='lnk-menu-profile']");
            public static By OrdersLink = By.CssSelector("[data-at='lnk-menu-orders']");
            public static By OrdersCountLabel = By.CssSelector("[class='nav-numbers order-nums']");
            public static By FavouritesLink = By.CssSelector("[data-at='lnk-menu-favourites']");
            public static By FavouritesCountLabel = By.CssSelector("[class='nav-numbers faves-nums']");
        }
    }
}
