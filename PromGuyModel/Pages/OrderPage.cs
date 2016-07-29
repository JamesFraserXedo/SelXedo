using CommonModel.Controls.Common.DatePicker;
using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;
using PromGuyModel.Controls.OrderJourney;

namespace PromGuyModel.Pages
{
    public class BaseOrderPage : PageBase
    {
        public BaseOrderPage(TestSettings testSettings) : base(testSettings)
        {
        }

        public override bool IsLoaded()
        {
            return Driver.ElementDisplayed(Locators.EventDatePicker);
        }

        public MinimisedDatePicker DatePicker
        {
            get { return new MinimisedDatePicker(TestSettings, Driver.FindElement(Locators.EventDatePicker)); }
        }

        public DeliveryAddressPanel DeliveryAddressForm
        {
            get { return new DeliveryAddressPanel(TestSettings); }
        }

        public IWebElement DeliveryDateLabel
        {
            get { return Driver.FindElement(Locators.DeliveryDateLabel); }
        }

        public IWebElement CollectionDateLabel
        {
            get { return Driver.FindElement(Locators.CollectionDateLabel); }
        }

        public SizeSelectorPanel SizeSelectorPanel
        {
            get { return new SizeSelectorPanel(TestSettings); }
        }

        protected Inputbox PromoCodeInputbox
        {
            get { return new Inputbox(Driver.FindElement(Locators.PromoCodeInputbox)); }
        }

        public IWebElement TuxPriceLabel
        {
            get { return Driver.FindElement(Locators.TuxPriceLabel); }
        }

        public IWebElement DiscountLabel
        {
            get { return Driver.FindElement(Locators.DiscountLabel); }
        }

        public IWebElement DamageAndHandlingLabel
        {
            get { return Driver.FindElement(Locators.DamageAndHandlingLabel); }
        }

        public IWebElement SalesTaxLabel
        {
            get { return Driver.FindElement(Locators.SalesTaxLabel); }
        }

        public IWebElement TotalLabel
        {
            get { return Driver.FindElement(Locators.TotalLabel); }
        }

        public Checkbox TermsAndConditionsCheckbox
        {
            get { return new Checkbox(Driver.FindElement(Locators.TermsAndConditionsCheckbox)); }
        }

        public Button ConfirmOrderButton
        {
            get { return new Button(Driver.FindElement(Locators.ConfirmOrderButton)); }
        }

        public string DeliveryDate
        {
            get { return DeliveryDateLabel.Text; }
        }

        public string CollectionDate
        {
            get { return CollectionDateLabel.Text; }
        }
        public string PromoCode
        {
            get { return PromoCodeInputbox.Text; }
            set { PromoCodeInputbox.SendKeys(value); }
        }

        public string TuxPrice
        {
            get { return TuxPriceLabel.Text; }
        }

        public string Discount
        {
            get { return DiscountLabel.Text; }
        }

        public string DamageAndHandling
        {
            get { return DamageAndHandlingLabel.Text; }
        }

        public string SalesTax
        {
            get { return SalesTaxLabel.Text; }
        }

        public string Total
        {
            get { return TotalLabel.Text; }
        }

        public class Locators
        {
            public static readonly By EventDatePicker = By.Id("event-calendar");

            public static readonly By DeliveryDateLabel = By.Id("delivery-date-display");
            public static readonly By CollectionDateLabel = By.Id("collectionDate");

            public static readonly By PromoCodeInputbox = By.CssSelector("[data-at='txt-singlewearer-order-commission-code']");
            public static readonly By TuxPriceLabel = By.Id("order-summary-outfit-price");
            public static readonly By DiscountLabel = By.ClassName("sub-total-discount");
            public static readonly By DamageAndHandlingLabel = By.Id("order-summary-adw-price");
            public static readonly By SalesTaxLabel = By.Id("order-summary-sales-tax");
            public static readonly By TotalLabel = By.Id("order-summary-price-inc-tax");
            public static readonly By TermsAndConditionsCheckbox = By.Id("AgreeTermsAndConditions");
            public static readonly By ConfirmOrderButton = By.Id("btn-confirm-order");
        }
    }
}
