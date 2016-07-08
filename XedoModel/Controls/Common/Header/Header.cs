using System;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace XedoModel.Controls.Common.Header
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

        public IWebElement CollectionsLink
        {
            get { return Driver.FindElement(Container, Locators.CollectionsLink); }
        }

        public IWebElement HowItWorksLink
        {
            get { return Driver.FindElement(Container, Locators.HowItWorksLink); }
        }

        public IWebElement GetInspiredLink
        {
            get { return Driver.FindElement(Container, Locators.GetInspiredLink); }
        }

        public IWebElement BuildATuxLink
        {
            get { return Driver.FindElement(Container, Locators.BuildATuxLink); }
        }
        
        public IWebElement OpenLoginPanelButton
        {
            get { return Driver.FindElement(Container, Locators.OpenLoginPanelButton); }
        }

        public IWebElement LoggedInUserNameLabel
        {
            get { return Driver.FindElement(Container, Locators.LoggedInUserNameLabel); }
        }

        public IWebElement OrdersButton
        {
            get { return Driver.FindElement(Container, Locators.OrdersButton); }
        }

        public IWebElement OrdersCountLabel
        {
            get { return Driver.FindElement(Container, Locators.OrdersCountLabel); }
        }

        public IWebElement FavouritesButton
        {
            get { return Driver.FindElement(Container, Locators.FavouritesButton); }
        }

        public IWebElement FavouritesCountLabel
        {
            get { return Driver.FindElement(Container, Locators.FavouritesCountLabel); }
        }

        public IWebElement LogoutButton
        {
            get { return Driver.FindElement(Container, Locators.LogoutButton); }
        }

        public bool LoggedIn
        {
            get { return Driver.ElementDisplayed(Locators.OpenLoginPanelButton); }
        }

        public string UserName
        {
            get { return LoggedInUserNameLabel.Text; }
        }

        public int NumberOfOrders
        {
            get { return Convert.ToInt32(OrdersCountLabel.Text); }
        }

        public int NumberOfFavourites
        {
            get { return Convert.ToInt32(FavouritesCountLabel.Text); }
        }

        public IWebElement GroomGoesFreeBanner
        {
            get { return Driver.FindElement(Locators.GroomGoesFreeBanner); }
        }

        public void Logout()
        {
            LogoutButton.Click();
        }

        public void GoToProfileSection()
        {
            LoggedInUserNameLabel.Click();
        }

        public class Locators
        {
            public static By Container = By.XPath("//div[contains(@class, 'header-container')]");

            public static By Logo = By.CssSelector("[class='img-responsive logo-name-section']");
            public static By CollectionsLink = By.CssSelector("[href='/collections']");
            public static By HowItWorksLink = By.CssSelector("[data-at='lnk-menu-how-it-works']");
            public static By GetInspiredLink = By.CssSelector("[data-at='lnk-menu-inspired']");
            public static By BuildATuxLink = By.CssSelector("[data-at='lnk-menu-outfit-builder']");

            public static By OpenLoginPanelButton = By.XPath("//*[contains(text(), 'Sign In')]");
            public static By LoggedInUserNameLabel = By.XPath("//span[@class='person-id']");
            public static By OrdersButton = By.Id("header-orders-button-with-count");
            public static By OrdersCountLabel = By.XPath("//*[@id='header-orders-button-with-count']/span");
            public static By FavouritesButton = By.Id("header-favourites-button-with-count");
            public static By FavouritesCountLabel = By.XPath("//*[@id='header-favourites-button-with-count']/span");
            public static By LogoutButton = By.Id("signout-link");
            public static By GroomGoesFreeBanner = By.CssSelector("[class='free-try-on-message']");
        }
    }
}
