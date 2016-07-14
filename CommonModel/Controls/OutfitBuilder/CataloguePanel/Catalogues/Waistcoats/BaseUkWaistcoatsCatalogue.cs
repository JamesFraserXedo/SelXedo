using System.Collections.ObjectModel;
using System.Linq;
using CommonModel.ClothingItems;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.OutfitBuilder.CataloguePanel.Catalogues.Waistcoats
{
    public abstract class BaseUkWaistcoatsCatalogue : BaseUkCatalogue
    {
        protected BaseUkWaistcoatsCatalogue(TestSettings testSettings) : base(testSettings)
        {
        }

        public ReadOnlyCollection<Waistcoat> Waistcoats
        {
            get
            {
                var elements = Container.FindElements(Locators.Waistcoats);
                return elements.Select(e => new Waistcoat(TestSettings, e)).ToList().AsReadOnly();
            }
        }

        public new class Locators : BaseUkCatalogue.Locators
        {
            public static readonly By Waistcoats = By.ClassName("item waistcoat");
        }
    }
}
