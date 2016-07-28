using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Pages
{
    public abstract class BaseTryOnBasketPage : PageBase
    {
        protected BaseTryOnBasketPage(TestSettings testSettings) : base(testSettings)
        {
        }

        public override bool IsLoaded()
        {
            return !Driver.ElementDisplayed(Locators.ConfirmTryOnButton);
        }

        public Button ConfirmTryOnButton
        {
            get { return new Button(Driver.FindElement(Locators.ConfirmTryOnButton)); }
        }

        public Checkbox TermsAndConditionsCheckbox
        {
            get { return new Checkbox(Driver.FindElement(Locators.TermsAndConditionsCheckbox)); }
        }

        public Button SaveOutfitButton
        {
            get { return new Button(Driver.FindElement(Locators.SaveOutfitButton)); }
        }

        public Button BackButton
        {
            get { return new Button(Driver.FindElement(Locators.BackButton)); }
        }

        protected Inputbox PhoneNumberInputbox
        {
            get { return new Inputbox(Driver.FindElement(Locators.PhoneNumberInputbox)); }
        }

        public IWebElement FeeLabel
        {
            get { return Driver.FindElement(Locators.FeeLabel); }
        }

        public string Fee
        {
            get { return FeeLabel.Text; }
        }

        public string PhoneNumber
        {
            get { return PhoneNumberInputbox.Text; }
            set { PhoneNumberInputbox.SendKeys(value); }
        }

        public class Locators
        {
            public static readonly By ConfirmTryOnButton = By.CssSelector("[data-at='btn-tryon-submit']");
            public static readonly By TermsAndConditionsCheckbox = By.CssSelector("[data-at='chk-check-tryon-tandc']");
            public static readonly By SaveOutfitButton = By.Id("btn-tryon-save");
            public static readonly By BackButton = By.CssSelector("[data-at='lnk-back']");
            public static readonly By FeeLabel = By.ClassName("total-price-display");
            public static readonly By PhoneNumberInputbox = By.CssSelector("[data-at='txt-try-on-basket-phone-no']");
            public static readonly By PreferredTryOnDatePicker = By.Id("try-on-calendar");
            public static readonly By WeddingDatePicker = By.Id("event-calendar");
        }
    }
}
