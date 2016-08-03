using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using CommonModel.ClothingItems;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.OutfitBuilder.CataloguePanel.Catalogues
{
    public class VestsAndCummerbundsCatalogue : BaseCatalogue
    {
        public VestsAndCummerbundsCatalogue(TestSettings testSettings) : base(testSettings)
        {
            Driver.WaitForElementToAppear(Locators.VestsAndCummerbunds);
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
            public static readonly By Vests = By.CssSelector("[class='item waistcoat']");
            public static readonly By Cummerbunds = By.CssSelector("[class='item cummerbund']");
            public static readonly By VestsAndCummerbunds = By.CssSelector("[class*='item-container all-waistcoats']>div");

        }
    }
}
