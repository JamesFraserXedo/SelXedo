using CommonModel.Controls.OutfitBuilder.FiltersPanel.Filters.Suits;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace YoungsModel.Controls.OutfitBuilder.FiltersPanel.Filters
{
    public class SuitFilter : UkSuitFilter
    {
        public SuitFilter(TestSettings testSettings) : base(testSettings)
        {
        }

        public SelectElement PrinceEdwardSelect
        {
            get { return new SelectElement(Driver.FindElement(Container, Locators.PrinceEdwardSelect)); }
        }

        public new class Locators : UkSuitFilter.Locators
        {
            public static By PrinceEdwardSelect = By.CssSelector("[value='Prince Edward']");
        }
    }
}
