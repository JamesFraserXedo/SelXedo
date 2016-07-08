using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace XedoModel.Controls.OutfitBuilder.Choosers.Neckwears
{
    public class Neckwear : ClothingItem
    {
        public Neckwear(TestSettings testSettings, IWebElement container) : base(testSettings, container)
        {
            Locators.ItemDetails = By.XPath(".//*[@data-level='neckwear']");
            Locators.NameLabel = By.XPath(".//*[contains(@class, 'colour-name')]");
        }
    }
}
