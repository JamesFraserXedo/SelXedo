using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace XedoModel.Controls.OutfitBuilder.Choosers.Waistcoats
{
    internal class Waistcoat : ClothingItem
    {
        public Waistcoat(TestSettings testSettings, IWebElement container) : base(testSettings, container)
        {
            Locators.ItemDetails = By.XPath("//*[@data-level='waistcoat']");
        }
    }
}
