using System;
using System.Collections.ObjectModel;
using System.Linq;
using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;
using TMLewinModel.Controls.HomePage;

namespace TMLewinModel.Pages
{
    public class HomePage : PageBase
    {
        public HomePage(TestSettings testSettings) : base(testSettings)
        {
        }

        public override bool IsLoaded()
        {
            return Driver.ElementDisplayed(Locators.Features);
        }

        public override void SetupState()
        {
            throw new NotImplementedException();
        }

        public Button GetStartedButton
        {
            get { return new Button(Driver.FindElement(Locators.GetStartedButton)); }
        }

        public ReadOnlyCollection<HomePageFeature> Features
        {
            get
            {
                var elements = Driver.FindElements(Locators.Features);
                return elements.Select(e => new HomePageFeature(TestSettings, e)).ToList().AsReadOnly();
            }
        }

        public Button SubFeatureButton
        {
            get { return new Button(Driver.FindElement(Locators.SubFeatureButton)); }
        }

        public ReadOnlyCollection<RecommendedStyle> RecommendedSuits
        {
            get
            {
                var elements = Driver.FindElements(Locators.RecommendedSuits);
                return elements.Select(e => new RecommendedStyle(TestSettings, e)).ToList().AsReadOnly();
            }
        }

        public Button PromoOfferButton
        {
            get { return new Button(Driver.FindElement(Locators.PromoOfferButton)); }
        }

        public ReadOnlyCollection<HomePageFeature> CompleteYourLookFeatures
        {
            get
            {
                var elements = Driver.FindElements(Locators.CompleteYourLookFeatures);
                return elements.Select(e => new HomePageFeature(TestSettings, e)).ToList().AsReadOnly();
            }
        }

        public class Locators
        {
            public static By GetStartedButton = By.CssSelector("[data-at='lnk-hero-get-started']");
            public static By Features = By.CssSelector("[class='block-link']");
            public static By SubFeatureButton = By.CssSelector("[data-at='lnk-sub-feature']");
            public static By RecommendedSuits = By.CssSelector("[class='recommended-suit block-link ga-event-click']");
            public static By PromoOfferButton = By.CssSelector("[data-at='lnk-promo-offer']");
            public static By CompleteYourLookFeatures = By.CssSelector("[class='row generic-row homepage-recsuits-row inner-row']>div");
        }
    }
}
