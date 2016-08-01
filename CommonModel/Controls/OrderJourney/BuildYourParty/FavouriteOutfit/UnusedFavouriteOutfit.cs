using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.OrderJourney.BuildYourParty.FavouriteOutfit
{
    public class UnusedFavouriteOutfit : BaseFavouriteOutfit
    {
        public UnusedFavouriteOutfit(TestSettings testSettings, IWebElement container) : base(testSettings, container)
        {
        }

        public Button AddToOrderButton
        {
            get { return new Button(Driver.FindElement(Container, Locators.AddToOrderButton)); }
        }

        public new class Locators : BaseFavouriteOutfit.Locators
        {
            public static readonly By AddToOrderButton = By.ClassName("build-party-favourites-selectoutfit button simple-cta");
        }
    }
}
