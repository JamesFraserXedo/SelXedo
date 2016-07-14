using CommonModel.Controls.OutfitSummary.TotalPane;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace PromGuyModel.Controls.OutfitSummary
{
    public abstract class TotalPanel : BaseUsTotalPanel
    {
        protected TotalPanel(TestSettings testSettings) : base(testSettings)
        {
        }

        public override IWebElement Container
        {
            get { return Driver.FindElement(Locators.Container); }
        }

        public new class Locators : BaseUsTotalPanel.Locators
        {
            public static readonly By Container = By.ClassName("row generic-row totals-row-promguy");
        }
    }
}
