using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonModel.Controls.HomePage;
using CommonModel.Controls.HomePage.ColourMatch;
using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace YoungsModel.Pages
{
    public class HomePage : PageBase
    {
        public HomePage(TestSettings testSettings) : base(testSettings)
        {
        }

        public override bool IsLoaded()
        {
            return Driver.ElementDisplayed(Locators.BannerLearnMoreButton);
        }

        public Button BannerLearnMoreButton
        {
            get { return new Button(Driver.FindElement(Locators.BannerLearnMoreButton)); }
        }

        public Button BannerCreateYourLookButton
        {
            get { return new Button(Driver.FindElement(Locators.BannerCreateYourLookButton)); }
        }

        public Button BannerFindOutMoreButton
        {
            get { return new Button(Driver.FindElement(Locators.BannerFindOutMoreButton)); }
        }

        public Button HomeTryOnFindOutMoreButton
        {
            get { return new Button(Driver.FindElement(Locators.HomeTryOnFindOutMoreButton)); }
        }

        public Button GetInspiredInspireMeButton
        {
            get { return new Button(Driver.FindElement(Locators.GetInspiredInspireMeButton)); }
        }

        public Button CreateYourLookCreateYourLookButton
        {
            get { return new Button(Driver.FindElement(Locators.CreateYourLookCreateYourLookButton)); }
        }

        public Button HowItWorksFindOutMoreButton
        {
            get { return new Button(Driver.FindElement(Locators.HowItWorksFindOutMoreButton)); }
        }

        public Button GroomGoesFreeLearnMoreButton
        {
            get { return new Button(Driver.FindElement(Locators.GroomGoesFreeLearnMoreButton)); }
        }

        public Button YoungsHireFindOutMoreButton
        {
            get { return new Button(Driver.FindElement(Locators.YoungsHireFindOutMoreButton)); }
        }

        public Button LearnMoreButton
        {
            get { return new Button(Driver.FindElement(Locators.LearnMoreButton)); }
        }

        public StyleCarousel StyleCarousel
        {
            get { return new StyleCarousel(TestSettings); }
        }

        public UkColourMatch ColourMatch
        {
            get { return new UkColourMatch(TestSettings); }
        }

        public class Locators
        {
            public static readonly By BannerLearnMoreButton = By.CssSelector("[class='owl-item active'] [class*='banner-three'] [data-at='lnk-home-banner']"); // Groom goes free
            public static readonly By BannerCreateYourLookButton = By.CssSelector("[class='owl-item cloned active'] [class*='banner-one'] [data-at='lnk-home-banner']"); // Suit hire made simple
            public static readonly By BannerFindOutMoreButton = By.CssSelector("[class='owl-item active'] [class*='banner-two'] [data-at='lnk-home-banner']"); // Home Try On

            public static readonly By HomeTryOnFindOutMoreButton = By.CssSelector("[class='free-home-try-on-content']>span");

            public static readonly By GetInspiredInspireMeButton = By.CssSelector("[data-at='lnk-feature-inspire-me'] [class='feature-item-btn-wrap']>span");
            public static readonly By CreateYourLookCreateYourLookButton = By.CssSelector("[data-at='lnk-feature-tux-builder'] [class='feature-item-btn-wrap']>span");
            public static readonly By HowItWorksFindOutMoreButton = By.CssSelector("[data-at='lnk-feature-how-it-works'] [class='feature-item-btn-wrap']>span");
            public static readonly By GroomGoesFreeLearnMoreButton = By.CssSelector("[data-at='lnk-feature-groom-goes-free'] [class='feature-item-btn-wrap']>span");

            public static readonly By YoungsHireFindOutMoreButton = By.CssSelector("[data-at='lnk-how-it-works-cta']");
            public static readonly By LearnMoreButton = By.CssSelector("[data-at='lnk-colour-match-cta']");

        }
    }
}
