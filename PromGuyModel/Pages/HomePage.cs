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

namespace PromGuyModel.Pages
{
    public class HomePage : PageBase
    {
        public HomePage(TestSettings testSettings) : base(testSettings)
        {
        }

        public override bool IsLoaded()
        {
            return Driver.ElementDisplayed(Locators.Banner);
        }

        public IWebElement Banner
        {
            get { return Driver.FindElement(Locators.Banner); }
        }

        public Button StartBuildingButton
        {
            get { return new Button(Driver.FindElement(Locators.StartBuildingButton)); }
        }

        public Button ViewItButton
        {
            get { return new Button(Driver.FindElement(Locators.ViewItButton)); }
        }

        public Button ColorMeButton
        {
            get { return new Button(Driver.FindElement(Locators.ColorMeButton)); }
        }

        public Button Save50Button
        {
            get { return new Button(Driver.FindElement(Locators.Save50Button)); }
        }

        public Button LetsGetThePartyStartedButton
        {
            get { return new Button(Driver.FindElement(Locators.LetsGetThePartyStartedButton)); }
        }

        public Button FindOutMoreButton
        {
            get { return new Button(Driver.FindElement(Locators.FindOutMoreButton)); }
        }

        public StyleCarousel StyleCarousel
        {
            get { return new StyleCarousel(TestSettings); }
        }

        public UsColourMatch ColourMatch
        {
            get { return new UsColourMatch(TestSettings); }
        }

        public Button ShopByColorButton
        {
            get {return new Button(Driver.FindElement(Locators.ShopByColorButton));}
        }

        public class Locators
        {
            public static readonly By Banner = By.CssSelector("[class='prom-guy-banner']");
            public static readonly By StartBuildingButton = By.CssSelector("[class='prom-guy-banner'] a");
            public static readonly By ViewItButton = By.CssSelector("[class='roundel roundel-one']");
            public static readonly By ColorMeButton = By.CssSelector("[class='roundel roundel-two']");
            public static readonly By Save50Button = By.CssSelector("[class='roundel roundel-three']");
            public static readonly By LetsGetThePartyStartedButton = By.CssSelector("[class='pg-lets-get-the-party-started'] a");
            public static readonly By FindOutMoreButton = By.CssSelector("[data-at='lnk-how-it-works-cta']");
            public static readonly By ShopByColorButton = By.CssSelector("[data-at='lnk-how-it-works-cta']");
        }
    }
}
