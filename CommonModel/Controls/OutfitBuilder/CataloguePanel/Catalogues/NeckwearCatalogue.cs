using System.Collections.ObjectModel;
using System.Linq;
using CommonModel.ClothingItems;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.OutfitBuilder.CataloguePanel.Catalogues
{
    public class NeckwearCatalogue : BaseCatalogue
    {
        public NeckwearCatalogue(TestSettings testSettings) : base(testSettings)
        {
        }

        public ReadOnlyCollection<Neckwear> Neckwear
        {
            get
            {
                var elements = Container.FindElements(Locators.Neckwear);
                return elements.Select(e => new Neckwear(TestSettings, e)).ToList().AsReadOnly();
            }
        }

        public new class Locators : BaseUkCatalogue.Locators
        {
            public static readonly By Neckwear = By.CssSelector("[data-at='lnk-neckwear']");
        }
    }
}
