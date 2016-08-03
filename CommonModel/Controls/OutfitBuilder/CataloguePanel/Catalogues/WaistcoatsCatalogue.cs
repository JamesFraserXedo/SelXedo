using System.Collections.ObjectModel;
using System.Linq;
using CommonModel.ClothingItems;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.OutfitBuilder.CataloguePanel.Catalogues
{
    public class WaistcoatsCatalogue : BaseUkCatalogue
    {
        public WaistcoatsCatalogue(TestSettings testSettings) : base(testSettings)
        {
            Driver.WaitForElementToAppear(Locators.Waistcoats);
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
            public static readonly By Waistcoats = By.CssSelector("[class='item waistcoat']");
        }
    }
}
