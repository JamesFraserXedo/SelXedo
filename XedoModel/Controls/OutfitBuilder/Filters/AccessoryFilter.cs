using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;


namespace Core.Controls.OutfitBuilder.Filters
{
    public class AccessoryFilter : FilterBase
    {
        public AccessoryFilter(TestSettings testSettings) : base(testSettings)
        {
            Locators.Container = By.Id("filters-accessories");
            SetActive();
        }
    }
}