using System.Collections.ObjectModel;
using System.Linq;
using CommonModel.ClothingItems;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.OutfitBuilder.CataloguePanel.Catalogues.Suits
{
    public abstract class BaseUkSuitsCatalogue : BaseUkCatalogue
    {
        protected BaseUkSuitsCatalogue(TestSettings testSettings) : base(testSettings)
        {
        }

        public ReadOnlyCollection<Suit> Suits
        {
            get
            {
                var elements = Container.FindElements(Locators.Suits);
                return elements.Select(e => new Suit(TestSettings, e)).ToList().AsReadOnly();
            }
        }

        public new class Locators : BaseCatalogue.Locators
        {
            public static By Suits = By.ClassName("item suit");
        }
    }
}
