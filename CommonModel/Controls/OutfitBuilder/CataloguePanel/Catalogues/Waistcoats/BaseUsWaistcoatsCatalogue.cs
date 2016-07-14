using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using CommonModel.ClothingItems;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.OutfitBuilder.CataloguePanel.Catalogues.Waistcoats
{
    public abstract class BaseUsWaistcoatsCatalogue : BaseCatalogue
    {
        protected BaseUsWaistcoatsCatalogue(TestSettings testSettings) : base(testSettings)
        {
        }

        public ReadOnlyCollection<Waistcoat> Vests
        {
            get
            {
                var elements = Container.FindElements(Locators.Vests);
                return elements.Select(e => new Waistcoat(TestSettings, e)).ToList().AsReadOnly();
            }
        }

        public ReadOnlyCollection<Waistcoat> Cummerbunds
        {
            get
            {
                var elements = Container.FindElements(Locators.Cummerbunds);
                return elements.Select(e => new Waistcoat(TestSettings, e)).ToList().AsReadOnly();
            }
        }

        public ReadOnlyCollection<Waistcoat> All
        {
            get
            {
                return (new ReadOnlyCollectionBuilder<Waistcoat>(Vests.Concat(Cummerbunds))).ToReadOnlyCollection();
            }
        }

        public new class Locators : BaseCatalogue.Locators
        {
            public static By Vests = By.ClassName("item waistcoat");
            public static By Cummerbunds = By.ClassName("item cummerbund");

        }
    }
}
