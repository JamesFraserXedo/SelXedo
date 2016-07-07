using System;
using System.Collections.Generic;
using System.Linq;
using Core.Controls.Collections;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

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

        public override void SetupState()
        {
            throw new NotImplementedException();
        }

        public class Locators
        {
            public static By OutfitContainer = By.XPath("//div[@class='inspire-item collection-single']");
        }
    }
}
