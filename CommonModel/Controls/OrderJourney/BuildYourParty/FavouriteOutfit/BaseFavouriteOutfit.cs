using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.OrderJourney.BuildYourParty.FavouriteOutfit
{
    public abstract class BaseFavouriteOutfit : ControlBase
    {
        protected IWebElement Container;

        protected BaseFavouriteOutfit(TestSettings testSettings, IWebElement container) : base(testSettings)
        {
            Container = container;
        }

        public IWebElement PreviewImage
        {
            get { return Driver.FindElement(Container, Locators.PreviewImage); }
        }

        public Button OpenOptionsButton
        {
            get { return new Button(Driver.FindElement(Container, Locators.OpenOptionsButton)); }
        }

        public Button CloseOptionsButton
        {
            get { return new Button(Driver.FindElement(Container, Locators.CloseOptionsButton)); }
        }

        public Button ViewOutfitButton
        {
            get { return new Button(Driver.FindElement(Container, Locators.ViewOutfitButton)); }
        }

        public Button CopyAndEditButton
        {
            get { return new Button(Driver.FindElement(Container, Locators.CopyAndEditButton)); }
        }

        public bool OptionsMenuOpen
        {
            get { return Driver.ElementDisplayed(Container, Locators.OptionsMenu); }
        }

        public void OpenOptionsMenu()
        {
            if (!OptionsMenuOpen)
            {
                OpenOptionsButton.Click();
            }
        }

        public void CloseOptionsMenu()
        {
            if (OptionsMenuOpen)
            {
                CloseOptionsButton.Click();
            }
        }
       
        public class Locators
        {
            public static readonly By PreviewImage = By.CssSelector("[class='control-favourite-image img-responsive']");
            public static readonly By OpenOptionsButton = By.CssSelector("[class='control-pen-icon iconset-more-vert']");
            public static readonly By CloseOptionsButton = By.CssSelector("[class='control-pen-icon iconset-close2']");
            public static readonly By OptionsMenu = By.CssSelector("[class='control-menu']");
            public static readonly By ViewOutfitButton = By.CssSelector("[class='control-favourite-view-button']");
            public static readonly By CopyAndEditButton = By.CssSelector("[class='build-party-favourites-copyedit']");
        }
    }
}
