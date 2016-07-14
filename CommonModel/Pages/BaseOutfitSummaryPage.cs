using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Pages
{
    public class BaseOutfitSummaryPage : PageBase
    {
        public BaseOutfitSummaryPage(TestSettings testSettings) : base(testSettings)
        {
        }

        public override bool IsLoaded()
        {
            return !Driver.ElementDisplayed(Locators.Loading);
        }

        public class Locators
        {
            public static readonly By Loading = By.ClassName("outfit-builder ob-loading");
        }
    }
}
