using System.Collections.ObjectModel;
using System.Linq;
using CommonModel.ClothingItems;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.OutfitBuilder.CataloguePanel.Catalogues
{
    public class ShirtsCatalogue : BaseCatalogue
    {
        public ShirtsCatalogue(TestSettings testSettings) : base(testSettings)
        {
        }

        public ReadOnlyCollection<Shirt> Shirts
        {
            get
            {
                var elements = Container.FindElements(Locators.Shirts);
                return elements.Select(e => new Shirt(TestSettings, e)).ToList().AsReadOnly();
            }
        }

        public new class Locators : BaseCatalogue.Locators
        {
            public static readonly By Shirts = By.CssSelector("[class='item shirt']");
        }
    }
}
