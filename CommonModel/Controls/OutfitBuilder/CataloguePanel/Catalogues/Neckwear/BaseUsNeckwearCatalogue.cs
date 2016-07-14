using System.Collections.ObjectModel;
using System.Linq;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.OutfitBuilder.CataloguePanel.Catalogues.Neckwear
{
    public abstract class BaseUsNeckwearCatalogue : BaseCatalogue
    {
        protected BaseUsNeckwearCatalogue(TestSettings testSettings) : base(testSettings)
        {
        }

        public ReadOnlyCollection<ClothingItems.Neckwear> Neckwear
        {
            get
            {
                var elements = Container.FindElements(Locators.Neckwear);
                return elements.Select(e => new ClothingItems.Neckwear(TestSettings, e)).ToList().AsReadOnly();
            }
        }

        public new class Locators : BaseUkCatalogue.Locators
        {
            public static By Neckwear = By.CssSelector("[data-at='lnk-neckwear']");
        }
    }
}
