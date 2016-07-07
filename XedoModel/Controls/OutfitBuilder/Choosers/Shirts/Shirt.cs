using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace Core.Controls.OutfitBuilder.Choosers.Shirts
{
    internal class Shirt : ClothingItem
    {
        public Shirt(TestSettings testSettings, IWebElement container) : base(testSettings, container)
        {
            Locators.ItemDetails = By.XPath("//*[@data-level='shirt']");
        }
    }
}
