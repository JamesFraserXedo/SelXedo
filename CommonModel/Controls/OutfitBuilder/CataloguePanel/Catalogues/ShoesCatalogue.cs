using System.Collections.ObjectModel;
using System.Linq;
using CommonModel.ClothingItems;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.OutfitBuilder.CataloguePanel.Catalogues
{
    public class ShoesCatalogue : BaseCatalogue
    {
        public ShoesCatalogue(TestSettings testSettings) : base(testSettings)
        {
        }

        public ReadOnlyCollection<Accessory> Shoes
        {
            get
            {
                var elements = Container.FindElements(Locators.Accessories);
                return elements.Select(e => new Accessory(TestSettings, e)).ToList().AsReadOnly();
            }
        }

        public new class Locators : BaseCatalogue.Locators
        {
            public static readonly By Accessories = By.CssSelector("[class='item accessory']");
        }
    }
}
