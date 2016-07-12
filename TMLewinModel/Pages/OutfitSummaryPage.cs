using System;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace TMLewinModel.Pages
{
    public class OutfitSummaryPage : PageBase
    {
        public OutfitSummaryPage(TestSettings testSettings) : base(testSettings)
        {
        }

        public override bool IsLoaded()
        {
            throw new NotImplementedException();
        }

        public override void SetupState()
        {
            throw new NotImplementedException();
        }

        public class Locators
        {
            public static By EditThisOutfitButton = By.ClassName("button secondary-cta product-type-edit");
            public static By RemoveJacketButton = By.CssSelector("[data-at='lnk-remove-jacket']");
            public static By SaveToFavouritesButton = By.CssSelector("[data-at='lnk-save-outfit']");
            public static By TotalLabel = By.Id("outfit-price-total");
            public static By TotalOrderValueLabel = By.Id("outfit-price-value");
            public static By AddToOrderButton = By.CssSelector("[data-at='lnk-add-to-order']");
            public static By OrderGroomsFreeTryOnButton = By.CssSelector("[data-at='lnk-try-on']");
        }
    }
}
