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

        public IWebElement OurStoryLink
        {
            get { return Driver.FindElement(Container, Locators.OurStoryLink); }
        }

        public IWebElement HelpAndFaqsLink
        {
            get { return Driver.FindElement(Container, Locators.HelpAndFaqsLink); }
        }

        public IWebElement ContactUsLink
        {
            get { return Driver.FindElement(Container, Locators.ContactUsLink); }
        }

        public IWebElement PressLink
        {
            get { return Driver.FindElement(Container, Locators.PressLink); }
        }

        public IWebElement CookiesAndPrivacyLink
        {
            get { return Driver.FindElement(Container, Locators.CookiesAndPrivacyLink); }
        }

        public IWebElement HowItWorksLink
        {
            get { return Driver.FindElement(Container, Locators.HowItWorksLink); }
        }

        public IWebElement PartnerSignUpLink
        {
            get { return Driver.FindElement(Container, Locators.PartnerSignUpLink); }
        }

        public IWebElement WeddingPlannerSignUpLink
        {
            get { return Driver.FindElement(Container, Locators.WeddingPlannerSignUpLink); }
        }

        public IWebElement BlogLink
        {
            get { return Driver.FindElement(Container, Locators.BlogLink); }
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
            public static By OurStoryLink = By.CssSelector("[data-at='lnk-footer-our-story']");
            public static By HelpAndFaqsLink = By.CssSelector("[data-at='lnk-footer-faqs']");
            public static By ContactUsLink = By.CssSelector("[data-at='lnk-footer-contact-us']");
            public static By PressLink = By.CssSelector("[data-at='lnk-footer-press']");
            public static By CookiesAndPrivacyLink = By.CssSelector("[data-at='lnk-footer-privacy']");
            public static By HowItWorksLink = By.CssSelector("[data-at='lnk-footer-how-it-works']");
            public static By PartnerSignUpLink = By.CssSelector("[data-at='lnk-footer-retailer-sign-up']");
            public static By WeddingPlannerSignUpLink = By.CssSelector("[data-at='lnk-footer-weddingplanner-sign-up']");
            public static By BlogLink = By.CssSelector("[data-at='lnk-footer-blog']");

            public static By PhoneNumberLabel = By.CssSelector("[data-at='lnk-footer-telephone']");
            public static By EmailLabel = By.CssSelector("[data-at='lnk-footer-email']");

            public static By SignUpEmailInputBox = By.CssSelector("[data-at='txt-footer-mailing']");
            public static By SignUpSubmitButton = By.CssSelector("[data-at='btn-footer-mailing']");

            public static By CopyrightLabel = By.CssSelector("[data-at='lnk-footer-xedo-us']");
        }
    }
}
