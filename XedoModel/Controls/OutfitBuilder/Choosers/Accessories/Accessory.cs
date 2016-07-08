using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace XedoModel.Controls.OutfitBuilder.Choosers.Accessories
{
    public class Accessory : ClothingItem
    {
        public Accessory(TestSettings testSettings, IWebElement container) : base(testSettings, container)
        {
            Locators.ItemDetails = By.XPath("//*[@data-level='accessories']");
        }
    }
}
