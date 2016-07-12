using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.Common.Footer
{
    public abstract class BaseFooter : ControlBase
    {
        protected BaseFooter(TestSettings testSettings) : base(testSettings)
        {
        }

        public IWebElement Container
        {
            get { return Driver.FindElement(Locators.Container); }
        }

        public Link TermsAndConditionsLink
        {
            get { return new Link(Driver.FindElement(Container, Locators.TermsAndConditionsLink)); }
        }

        public Link HowItWorksLink
        {
            get { return new Link(Driver.FindElement(Container, Locators.HowItWorksLink)); }
        }

        public Link CookiesAndPrivacyLink
        {
            get { return new Link(Driver.FindElement(Container, Locators.CookiesAndPrivacyLink)); }
        }

        public Link HelpAndFaqsLink
        {
            get { return new Link(Driver.FindElement(Container, Locators.HelpAndFaqsLink)); }
        }

        public IWebElement PhoneNumberLabel
        {
            get { return Driver.FindElement(Container, Locators.PhoneNumberLabel); }
        }

        public IWebElement EmailLabel
        {
            get { return Driver.FindElement(Container, Locators.EmailLabel); }
        }

        public class Locators
        {
            public static By Container = By.CssSelector("[class='container-fluid footer-container']");

            public static By TermsAndConditionsLink = By.CssSelector("[data-at='lnk-footer-terms']");
            public static By HowItWorksLink = By.CssSelector("[data-at='lnk-footer-how-it-works']");
            public static By CookiesAndPrivacyLink = By.CssSelector("[data-at='lnk-footer-privacy']");
            public static By HelpAndFaqsLink = By.CssSelector("[data-at='lnk-footer-faqs']");
            
            public static By PhoneNumberLabel = By.CssSelector("[data-at='lnk-footer-telephone']");
            public static By EmailLabel = By.CssSelector("[data-at='lnk-footer-email']");
        }
    }
}
