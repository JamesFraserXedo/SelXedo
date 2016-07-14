using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.OutfitBuilder.CataloguePanel.Catalogues
{
    public abstract class BaseUkCatalogue : BaseCatalogue
    {
        protected BaseUkCatalogue(TestSettings testSettings) : base(testSettings)
        {
        }

        public Checkbox ToggleChildSizesCheckbox
        {
            get { return new Checkbox(Driver.FindElement(Container, Locators.ToggleChildSizesCheckbox)); }
        }

        public new class Locators : BaseCatalogue.Locators
        {
            public static readonly By ToggleChildSizesCheckbox = By.Id("adultchild-toggle");
        }
    }
}
