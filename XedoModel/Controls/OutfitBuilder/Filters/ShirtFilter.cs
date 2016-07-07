using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace Core.Controls.OutfitBuilder.Filters
{
    public class ShirtFilter : FilterBase
    {
        public ShirtFilter(TestSettings testSettings) : base(testSettings)
        {
            Locators.Container = By.Id("filters-shirt");
            SetActive();
        }
    }
}