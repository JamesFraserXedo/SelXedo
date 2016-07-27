using CommonModel.Controls.OutfitBuilder.FiltersPanel.Filters.Suits;
using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace YoungsModel.Controls.OutfitBuilder.FiltersPanel.Filters
{
    public class SuitFilter : UkSuitFilter
    {
        public SuitFilter(TestSettings testSettings) : base(testSettings)
        {
        }

        public Selector PrinceEdwardSelect
        {
            get { return new Selector(Driver.FindElement(Container, Locators.PrinceEdwardSelect)); }
        }

        public new class Locators : UkSuitFilter.Locators
        {
            public static readonly By PrinceEdwardSelect = By.CssSelector("[value='Prince Edward']");
        }
    }
}
