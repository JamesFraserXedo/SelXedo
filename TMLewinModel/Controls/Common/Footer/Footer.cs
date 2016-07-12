using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace TMLewinModel.Controls.Common.Footer
{
    public class Footer : ControlBase
    {
        public Footer(TestSettings testSettings) : base(testSettings)
        {
        }

        public IWebElement Container
        {
            get { return Driver.FindElement(Locators.Container); }
        }

        public IWebElement Logo
        {
            get { return Driver.FindElement(Container, Locators.Logo); }
        }
        
        public IWebElement TermsAndConditionsLink
        {
            get { return Driver.FindElement(Container, Locators.TermsAndConditionsLink); }
        }

        public IWebElement HowItWorksLink
        {
            get { return Driver.FindElement(Container, Locators.HowItWorksLink); }
        }

        public IWebElement PriceListLink
        {
            get { return Driver.FindElement(Container, Locators.PriceListLink); }
        }

        public IWebElement CookiesAndPrivacyLink
        {
            get { return Driver.FindElement(Container, Locators.CookiesAndPrivacyLink); }
        }

        public IWebElement HelpAndFaqsLink
        {
            get { return Driver.FindElement(Container, Locators.HelpAndFaqsLink); }
        }

        public IWebElement FreeDeliveryAndReturnsLink
        {
            get { return Driver.FindElement(Container, Locators.FreeDeliveryAndReturnsLink); }
        }

        public IWebElement PhoneNumberLabel
        {
            get { return Driver.FindElement(Container, Locators.PhoneNumberLabel); }
        }

        public IWebElement EmailLabel
        {
            get { return Driver.FindElement(Container, Locators.EmailLabel); }
        }

        public InputBox SignUpEmailInputBox
        {
            get { return new InputBox(Driver.FindElement(Container, Locators.SignUpEmailInputBox)); }
        }

        public Button SignUpSubmitButton
        {
            get { return new Button(Driver.FindElement(Container, Locators.SignUpSubmitButton)); }
        }

        public IWebElement CopyrightLabel
        {
            get { return Driver.FindElement(Container, Locators.CopyrightLabel); }
        }

        public class Locators
        {
            public static By Container = By.CssSelector("[class='container-fluid footer-container']");

            public static By Logo = By.CssSelector("[data-at='lnk-footer-logo']");

            public static By TermsAndConditionsLink = By.CssSelector("[data-at='lnk-footer-terms']");
            public static By HowItWorksLink = By.CssSelector("[data-at='lnk-footer-how-it-works']");
            public static By PriceListLink = By.CssSelector("[data-at='lnk-footer-pricelist']");
            public static By CookiesAndPrivacyLink = By.CssSelector("[data-at='lnk-footer-privacy']");
            public static By HelpAndFaqsLink = By.CssSelector("[data-at='lnk-footer-faqs']");
            public static By FreeDeliveryAndReturnsLink = By.CssSelector("[data-at='lnk-footer-menu-freedelivery']");
            
            public static By PhoneNumberLabel = By.CssSelector("[data-at='lnk-footer-telephone']");
            public static By EmailLabel = By.CssSelector("[data-at='lnk-footer-email']");

            public static By SignUpEmailInputBox = By.CssSelector("[data-at='txt-footer-mailing']");
            public static By SignUpSubmitButton = By.CssSelector("[data-at='btn-footer-mailing']");

            public static By CopyrightLabel = By.CssSelector("[data-at='lnk-footer-xedo-uk']");
        }
    }
}
