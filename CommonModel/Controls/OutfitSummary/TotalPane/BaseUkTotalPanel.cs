using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.OutfitSummary.TotalPane
{
    public abstract class BaseUkTotalPanel : BaseTotalPanel
    {
        protected BaseUkTotalPanel(TestSettings testSettings) : base(testSettings)
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

        public IWebElement TotalLabel
        {
            get { return Driver.FindElement(Container, Locators.TotalLabel); }
        }

        public IWebElement TotalOrderValueLabel
        {
            get { return Driver.FindElement(Container, Locators.TotalOrderValueLabel); }
        }

        public string Total
        {
            get { return TotalLabel.Text; }
        }

        public string TotalOrderValue
        {
            get { return TotalOrderValueLabel.Text; }
        }

        public new class Locators : BaseTotalPanel.Locators
        {
            public static readonly By Container = By.ClassName("row generic-row totals-row");
            public static readonly By OrderFreeTryOnButton = By.CssSelector("[data-at='lnk-try-on']");
            public static readonly By TotalLabel = By.Id("outfit-price-total");
            public static readonly By TotalOrderValueLabel = By.Id("outfit-price-value");
        }
    }
}
