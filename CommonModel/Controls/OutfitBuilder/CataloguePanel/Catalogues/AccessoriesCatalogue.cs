using System.Collections.ObjectModel;
using System.Linq;
using CommonModel.ClothingItems;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.OutfitBuilder.CataloguePanel.Catalogues
{
    public class AccessoriesCatalogue : BaseUkCatalogue
    {
        public AccessoriesCatalogue(TestSettings testSettings) : base(testSettings)
        {
            Driver.WaitForElementToAppear(Locators.Accessories);
        }

        public ReadOnlyCollection<Accessory> Accessories
        {
            get
            {
                var elements = Container.FindElements(Locators.Accessories);
                return elements.Select(e => new Accessory(TestSettings, e)).ToList().AsReadOnly();
            }
        }

        public new class Locators : BaseUkCatalogue.Locators
        {
            public static readonly By Accessories = By.CssSelector("[class='item accessory']");
        }
    }
}
