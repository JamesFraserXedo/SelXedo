using System.Collections.ObjectModel;
using System.Linq;
using CommonModel.ClothingItems;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.OutfitBuilder.CataloguePanel.Catalogues
{
    public class TuxedosCatalogue : BaseCatalogue
    {
        public TuxedosCatalogue(TestSettings testSettings) : base(testSettings)
        {
            Driver.WaitForElementToAppear(SuitsCatalogue.Locators.Suits);
        }

        public ReadOnlyCollection<Suit> Tuxedos
        {
            get
            {
                var elements = Container.FindElements(Locators.Suits);
                return elements.Select(e => new Suit(TestSettings, e)).ToList().AsReadOnly();
            }
        }

        public new class Locators : BaseCatalogue.Locators
        {
            public static readonly By Suits = By.CssSelector("[class='item suit']");
        }
    }
}
