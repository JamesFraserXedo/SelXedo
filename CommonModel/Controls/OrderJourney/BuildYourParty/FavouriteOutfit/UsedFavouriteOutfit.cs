using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.OrderJourney.BuildYourParty.FavouriteOutfit
{
    public class UsedFavouriteOutfit : BaseFavouriteOutfit
    {
        public UsedFavouriteOutfit(TestSettings testSettings, IWebElement container) : base(testSettings, container)
        {
        }

        public new class Locators : BaseFavouriteOutfit.Locators
        {
            public static readonly By AlreadyInUseLabel = By.ClassName("already-used");
        }
    }
}
