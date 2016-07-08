using System.Collections.ObjectModel;
using System.Linq;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;
using XedoModel.Controls.QuickTryOn;


namespace XedoModel.Pages
{
    public class QuickTryOnPage : PageBase
    {
        public QuickTryOnPage(TestSettings testSettings) : base(testSettings)
        {
            TryOnPopup.Dismiss();
        }

        public IWebElement TermsAndConditionsCheckbox
        {
            get { return Driver.FindElement(Locators.TermsAndConditionsCheckbox); }
        }

        public IWebElement ReviewAndConfirmTryOnButton
        {
            get { return Driver.FindElement(Locators.ReviewAndConfirmTryOnButton); }
        }

        public TryOnPopup TryOnPopup
        {
            get { return new TryOnPopup(TestSettings); }
        }

        public InfoForm InfoForm
        {
            get { return new InfoForm(TestSettings); }
        }

        public ColourSelect ColourSelect
        {
            get { return new ColourSelect(TestSettings); }
        }

        public ReadOnlyCollection<string> ErrorMessages
        {
            get
            {
                var errors = Driver.FindElements(Locators.TryOnErrorMessages);
                var messages = errors.Select(webElement => webElement.Text).ToList();
                return messages.AsReadOnly();
            }
        } 

        public override bool IsLoaded()
        {
            return InfoForm.Container.Displayed || TryOnPopup.Container.Displayed;
        }

        public override void SetupState()
        {
            
        }

        public void AgreeToTermsAndConditions()
        {
            if (!TermsAndConditionsCheckbox.Selected)
            {
                TermsAndConditionsCheckbox.Click();
            }
        }

        public void PlaceOrder()
        {
            ReviewAndConfirmTryOnButton.Click();
        }

        public class Locators
        {
            public static By ReviewAndConfirmTryOnButton = By.XPath("//*[@data-galabel='quick-try-on-confirm']");
            public static By TermsAndConditionsCheckbox = By.Id("AgreeTermsAndConditions");
            public static By TryOnErrorMessages = By.XPath("//*[@class='tryon-error']");
        }
    }
}
