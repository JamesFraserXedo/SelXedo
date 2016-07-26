using CommonModel.Controls.Common.DatePicker;
using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Pages
{
    public abstract class BaseSelectWeddingDatePage : PageBase
    {
        protected BaseSelectWeddingDatePage(TestSettings testSettings) : base(testSettings)
        {
        }

        public override bool IsLoaded()
        {
            return Driver.ElementDisplayed(Locators.ConfirmWeddingDateButton) ||
                   Driver.ElementDisplayed(Locators.EditWeddingDateButton);
        }

        public EmbeddedDatePicker DatePicker
        {
            get { return new EmbeddedDatePicker(TestSettings); }
        }

        public Button ConfirmWeddingDateButton
        {
            get { return new Button(Driver.FindElement(Locators.ConfirmWeddingDateButton)); }
        }

        public Button EditWeddingDateButton
        {
            get { return new Button(Driver.FindElement(Locators.EditWeddingDateButton)); }
        }

        public Button BackButton
        {
            get { return new Button(Driver.FindElement(Locators.BackButton)); }
        }
    
        public Button ContinueButton
        {
            get { return new Button(Driver.FindElement(Locators.ContinueButton)); }
        }

        public IWebElement ConfirmedWeddingDateLabel
        {
            get { return Driver.FindElement(Locators.ConfirmedWeddingDateLabel); }
        }

        public IWebElement DeliveryDateLabel
        {
            get { return Driver.FindElement(Locators.DeliveryDateLabel); }
        }

        public IWebElement CollectionDateLabel
        {
            get { return Driver.FindElement(Locators.CollectionDateLabel); }
        }

        public string ConfirmedWeddingDate
        {
            get { return ConfirmedWeddingDateLabel.Text; }
        }

        public string DeliveryDate
        {
            get { return DeliveryDateLabel.Text; }
        }

        public string CollectionDate
        {
            get { return CollectionDateLabel.Text; }
        }

        public class Locators
        {
            public static By ConfirmWeddingDateButton = By.CssSelector("[data-at='lnk-confirm-wedding-date']");
            public static By BackButton = By.Id("btn-wedding-date-back");
            public static By ContinueButton = By.CssSelector("[data-at='btn-wedding-date-next']");
            public static By ConfirmedWeddingDateLabel = By.CssSelector("[data-at='set-confirmed-wedding-date']");
            public static By DeliveryDateLabel = By.Id("deliveryDate");
            public static By CollectionDateLabel = By.Id("collectionDate");
            public static By EditWeddingDateButton = By.Id("edit-wedding-date");
        }
    }
}
