using System;
using System.Collections.Generic;
using System.Linq;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;
using XedoModel.Controls.Collections;

namespace XedoModel.Pages
{
    public class CollectionsPage : PageBase
    {
        public CollectionsPage(TestSettings testSettings) : base(testSettings)
        {
        }

        public IReadOnlyCollection<CollectionOutfit> Outfits
        {
            get
            {
                var elements = Driver.FindElements(Locators.OutfitContainer);
                var list = elements.Select(webElement => new CollectionOutfit(TestSettings, webElement)).ToList();
                return list.AsReadOnly();
            }
        }

        public override bool IsLoaded()
        {
            return Driver.ElementDisplayed(Locators.OutfitContainer);
        }
        
        public class Locators
        {
            public static By Title = By.CssSelector("[class='page-intro-header']");

            public static By OutfitContainer = By.CssSelector("[class='inspire-item collection-single']");
        }
    }
}
