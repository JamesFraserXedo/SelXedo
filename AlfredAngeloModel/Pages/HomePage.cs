using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace AlfredAngeloModel.Pages
{
    public class HomePage : PageBase
    {
        public HomePage(TestSettings testSettings) : base(testSettings)
        {
        }

        public override bool IsLoaded()
        {
            return Driver.ElementDisplayed(Locators.ActiveImage);
        }

        public IWebElement ActiveImage
        {
            get { return Driver.FindElement(Locators.ActiveImage); }
        }

        public Button AddToFavouritesButton
        {
            get { return new Button(Driver.FindElement(ActiveImage, Locators.AddToFavouritesButton)); }
        }

        public Button ViewInOutfitBuilderButton
        {
            get { return new Button(Driver.FindElement(ActiveImage, Locators.ViewInOutfitBuilderButton)); }
        }

        public ReadOnlyCollection<IWebElement> Thumbnails
        {
            get { return Driver.FindElements(Locators.Thumbnails); }
        }

        public Button LeftArrow
        {
            get { return new Button(Driver.FindElement(Locators.LeftArrow)); }
        }

        public Button RightArrow
        {
            get { return new Button(Driver.FindElement(Locators.RightArrow)); }
        }

        public class Locators
        {
            public static readonly By ActiveImage = By.CssSelector("[class='item active']");
            public static readonly By AddToFavouritesButton = By.CssSelector("[data-at='lnk-add-to-favourites']");
            public static readonly By ViewInOutfitBuilderButton = By.CssSelector("[data-at='lnk-view-outfit']");
            public static readonly By Thumbnails = By.CssSelector("[class='carousel-indicators inspire-indicators']>li");
            public static readonly By LeftArrow = By.CssSelector("[class='iconset-carousel-left-arrow']");
            public static readonly By RightArrow = By.CssSelector("[class='iconset-carousel-right-arrow']");
        }
    }
}
