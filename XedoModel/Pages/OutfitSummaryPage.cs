using System;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;
using XedoModel.Controls.OutfitSummary;

namespace XedoModel.Pages
{
    public class OutfitSummaryPage : PageBase
    {
        public OutfitSummaryPage(TestSettings testSettings) : base(testSettings)
        {
        }

        public IWebElement AddToOrderButton
        {
            get { return Driver.FindElement(Locators.AddToOrderButton); }
        }

        public IWebElement OrderFreeTryOnButton
        {
            get { return Driver.FindElement(Locators.OrderFreeTryOnButton); }
        }

        public IWebElement CustomiseTuxButton
        {
            get { return Driver.FindElement(Locators.CustomiseTuxButton); }
        }

        public IWebElement TotalLabel
        {
            get { return Driver.FindElement(Locators.TotalLabel); }
        }

        public string TotalDue
        {
            get { return TotalLabel.Text; }
        }

        public override bool IsLoaded()
        {
            return !Driver.ElementDisplayed(Locators.IsLoadingSpinner);
        }
        
        public class Locators
        {
            public static readonly By CustomiseTuxButton = By.XPath("//div[contains(@class, 'customize-look-holder')]/a");
            public static readonly By TuxSummaryObject = By.XPath("//div[@data-at='click-jacket']");
            public static readonly By WaistcoatSummaryObject = By.XPath("//div[@data-at='click-waistcoat-cummerbund']");
            public static readonly By NeckwearSummaryObject = By.XPath("//div[@data-at='click-neckwear']");
            public static readonly By ShirtSummaryObject = By.XPath("//div[@data-at='click-shirt']");
            public static readonly By AccessoriesSummaryObject = By.XPath("//div[@data-at='click-accessories']");
            public static readonly By SummaryDetailsPanel = By.XPath("//div[@class='outfit-selection-content']");
            public static readonly By AddToOrderButton = By.Id("placeorder");
            public static readonly By OrderFreeTryOnButton = By.Id("book-try-on");

            public static readonly By SubtotalPriceLabel = By.XPath("//span[@class='sub-total-amount']");
            public static readonly By SubtotalDiscountByLabel = By.XPath("//span[@class='sub-total-discount']");
            public static readonly By TotalLabel = By.XPath("//span[@class='total-amount']");

            public static readonly By IsLoadingSpinner = By.XPath("//*[@class='outfit-builder ob-loading']");
        }
    }
}
