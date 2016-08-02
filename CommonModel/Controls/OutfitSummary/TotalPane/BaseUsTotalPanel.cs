using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.OutfitSummary.TotalPane
{
    public abstract class BaseUsTotalPanel : BaseTotalPanel
    {
        protected BaseUsTotalPanel(TestSettings testSettings) : base(testSettings)
        {
        }

        public IWebElement PriceLabel
        {
            get { return Driver.FindElement(Container, Locators.PriceLabel); }
        }

        public IWebElement DiscountLabel
        {
            get { return Driver.FindElement(Container, Locators.DiscountLabel); }
        }

        public IWebElement TotalLabel
        {
            get { return Driver.FindElement(Container, Locators.TotalLabel); }
        }

        public string Price
        {
            get { return PriceLabel.Text; }
        }

        public string Discount
        {
            get { return DiscountLabel.Text; }
        }

        public string Total
        {
            get { return TotalLabel.Text; }
        }

        public new class Locators : BaseTotalPanel.Locators
        {
            public static readonly By PriceLabel = By.CssSelector("[class='sub-total-amount']");
            public static readonly By DiscountLabel = By.CssSelector("[class='sub-total-discount']");
            public static readonly By TotalLabel = By.CssSelector("[class='total-amount']");
        }
    }
}
