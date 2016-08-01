using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using CommonModel.Controls.OrderJourney.BuildYourParty.FavouriteOutfit;
using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Pages.OrderJourney.BuildYourPartyPage
{
    public abstract class BaseBuildYourPartyPage : PageBase
    {
        protected BaseBuildYourPartyPage(TestSettings testSettings) : base(testSettings)
        {
        }

        public override bool IsLoaded()
        {
            return Driver.ElementDisplayed(Locators.OutfitPanels);
        }

        public Link EditWeddingDateLink
        {
            get { return new Link(Driver.FindElement(Locators.EditWeddingDateLink)); }
        }

        public Button AddAnotherOutfitButton
        {
            get { return new Button(Driver.FindElement(Locators.AddAnotherOutfitButton)); }
        }

        public Button CreateNewPartyMemberButton
        {
            get { return new Button(Driver.FindElement(Locators.CreateNewPartyMemberButton)); }
        }

        public Button ViewGroupShotButton
        {
            get { return new Button(Driver.FindElement(Locators.ViewGroupShotButton)); }
        }

        public Button BackButton
        {
            get { return new Button(Driver.FindElement(Locators.BackButton)); }
        }

        public Button SaveAndContinueToBillingAddressButton
        {
            get { return new Button(Driver.FindElement(Locators.SaveAndContinueToBillingAddressButton)); }
        }

        public Button SaveToDraftButton
        {
            get { return new Button(Driver.FindElement(Locators.SaveToDraftButton)); }
        }

        public Button CloseFavouritesButton
        {
            get { return new Button(Driver.FindElement(Locators.CloseFavouritesButton)); }
        }

        public Button ClearUnusedFavouritesButton
        {
            get { return new Button(Driver.FindElement(Locators.ClearUnusedFavouritesButton)); }
        }

        public Button CreateNewOutfitButton
        {
            get { return new Button(Driver.FindElement(Locators.CreateNewOutfitButton)); }
        }
        
        protected ReadOnlyCollection<IWebElement> OutfitWearerPanelElements
        {
            get { return Driver.FindElements(Locators.OutfitPanels); }
        }

        protected ReadOnlyCollection<IWebElement> FavouriteOutfitElements
        {
            get { return Driver.FindElements(Locators.FavouriteOutfits); }
        }

        protected ReadOnlyCollection<IWebElement> UnusedFavouriteOutfitElements
        {
            get { return Driver.FindElements(Locators.UnusedFavouriteOutfits); }
        }

        protected ReadOnlyCollection<IWebElement> UsedFavouriteOutfitElements
        {
            get { return Driver.FindElements(Locators.UsedFavouriteOutfits); }
        }

        public ReadOnlyCollection<BaseFavouriteOutfit> FavouriteOutfits
        {
            get
            {
                var list = new List<BaseFavouriteOutfit>();
                foreach (var baseFavouriteOutfit in FavouriteOutfitElements)
                {
                    if (Driver.ElementDisplayed(baseFavouriteOutfit, UsedFavouriteOutfit.Locators.AlreadyInUseLabel))
                    {
                        list.Add(new UsedFavouriteOutfit(TestSettings, baseFavouriteOutfit));
                    }
                    else if (Driver.ElementDisplayed(baseFavouriteOutfit, UnusedFavouriteOutfit.Locators.AddToOrderButton))
                    {
                        list.Add(new UnusedFavouriteOutfit(TestSettings, baseFavouriteOutfit));
                    }
                }
                return list.AsReadOnly();
            }
        }

        public ReadOnlyCollection<BaseFavouriteOutfit> UsedFavouriteOutfits
        {
            get
            {
                return (from baseFavouriteOutfit in FavouriteOutfitElements
                        where Driver.ElementDisplayed(baseFavouriteOutfit, UsedFavouriteOutfit.Locators.AlreadyInUseLabel)
                        select new UsedFavouriteOutfit(TestSettings, baseFavouriteOutfit)).Cast<BaseFavouriteOutfit>()
                    .ToList()
                    .AsReadOnly();
            }
        } 

        public ReadOnlyCollection<BaseFavouriteOutfit> UnusedFavouriteOutfits
        {
            get
            {
                return (from baseFavouriteOutfit in FavouriteOutfitElements
                        where Driver.ElementDisplayed(baseFavouriteOutfit, UnusedFavouriteOutfit.Locators.AddToOrderButton)
                        select new UnusedFavouriteOutfit(TestSettings, baseFavouriteOutfit)).Cast<BaseFavouriteOutfit>()
                    .ToList()
                    .AsReadOnly();
            }
        }

        public class Locators
        {
            public static readonly By EditWeddingDateLink = By.CssSelector("[class='build-party-wedding-date']>a");
            public static readonly By OutfitPanels = By.CssSelector("[class*='worn-outfits']>[class='outfit-holder']");
            public static readonly By AddAnotherOutfitButton = By.Id("add-new-outfit-from-unworn-favourites");
            public static readonly By CreateNewPartyMemberButton = By.Id("add-new-wearer-button");
            public static readonly By ViewGroupShotButton = By.ClassName("button simple-cta photolink");
            public static readonly By BackButton = By.CssSelector("[data-at='lnk-back-build-party']");
            public static readonly By SaveAndContinueToBillingAddressButton = By.CssSelector("[data-at='lnk-build-party-go-button']");
            public static readonly By SaveToDraftButton = By.Id("save-draft-order");
            public static readonly By CloseFavouritesButton = By.ClassName("close-unworn-favourites");
            public static readonly By ClearUnusedFavouritesButton = By.ClassName("clear-unused-favourites remove-unusedOutfits");
            public static readonly By CreateNewOutfitButton = By.ClassName("outfit-add-wearer-button");
            public static readonly By FavouriteOutfits = By.CssSelector("[class*='control control-favourite favourite-']");
            public static readonly By UnusedFavouriteOutfits = By.ClassName("control control-favourite favourite-not-used");
            public static readonly By UsedFavouriteOutfits = By.ClassName("control control-favourite favourite-in-use");
        }
    }
}
