using CommonModel.Controls.OutfitSummary.TotalPane;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace PromGuyModel.Controls.OutfitSummary
{
    public class TotalPanel : BaseUsTotalPanel
    {
        public TotalPanel(TestSettings testSettings) : base(testSettings)
        {
        }

        public override IWebElement Container
        {
            get { return Driver.FindElement(Locators.Container); }
        }

        public new class Locators : BaseUsTotalPanel.Locators
        {
            public static readonly By Container = By.CssSelector("[class='row generic-row totals-row-promguy']");
        }
    }
}
