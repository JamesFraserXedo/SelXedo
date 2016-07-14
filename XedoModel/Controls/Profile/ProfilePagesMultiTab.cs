using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace XedoModel.Controls.Profile
{
    public class ProfilePagesMultiTab : ControlBase
    {
        public ProfilePagesMultiTab(TestSettings testSettings) : base(testSettings)
        {
        }

        public IWebElement ManageProfileTabButton
        {
            get { return Driver.FindElement(Locators.ManageProfileTabButton); }
        }

        public IWebElement OrdersTabButton
        {
            get { return Driver.FindElement(Locators.OrdersTabButton); }
        }

        public IWebElement AddressBookTabButton
        {
            get { return Driver.FindElement(Locators.AddressBookTabButton); }
        }

        public IWebElement FavouritesTabButton
        {
            get { return Driver.FindElement(Locators.FavouritesTabButton); }
        }

        public class Locators
        {
            public static readonly By ManageProfileTabButton = By.Id("ManageProfile");
            public static readonly By OrdersTabButton = By.Id("Orders");
            public static readonly By AddressBookTabButton = By.Id("AddressBook");
            public static readonly By FavouritesTabButton = By.Id("Favourites");
        }
    }
}
