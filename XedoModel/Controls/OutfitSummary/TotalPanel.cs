using CommonModel.Controls.OutfitSummary.TotalPane;
using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace XedoModel.Controls.OutfitSummary
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

        public Button OrderFreeTryOnButton
        {
            get { return new Button(Driver.FindElement(Container, Locators.OrderFreeTryOnButton)); }
        }
    
        public new class Locators : BaseUsTotalPanel.Locators
        {
            public static readonly By Container = By.ClassName("row generic-row totals-row-promguy");
            public static readonly By OrderFreeTryOnButton = By.CssSelector("[data-at='lnk-try-on']");
        }
    }
}
