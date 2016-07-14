using System.Data;
using System.Runtime.Remoting;
using CommonModel.Controls.Common.Footer;
using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace XedoModel.Controls.Common.Footer
{
    public class Footer : SignupFooter
    {
        public Footer(TestSettings testSettings) : base(testSettings)
        {
        }

        public IWebElement Logo
        {
            get { return Driver.FindElement(Container, Locators.Logo); }
        }

        public Link OurStoryLink
        {
            get { return new Link(Driver.FindElement(Container, Locators.OurStoryLink)); }
        }

        public Link PressLink
        {
            get { return new Link(Driver.FindElement(Container, Locators.PressLink)); }
        }

        public Link PartnerSignUpLink
        {
            get { return new Link(Driver.FindElement(Container, Locators.PartnerSignUpLink)); }
        }

        public Link WeddingPlannerSignUpLink
        {
            get { return new Link(Driver.FindElement(Container, Locators.WeddingPlannerSignUpLink)); }
        }

        public Link BlogLink
        {
            get { return new Link(Driver.FindElement(Container, Locators.BlogLink)); }
        }

        public Link ContactUsLink
        {
            get { return new Link(Driver.FindElement(Container, Locators.ContactUsLink)); }
        }

        public new class Locators : SignupFooter.Locators
        {
            public static readonly By Logo = By.CssSelector("[data-at='lnk-footer-logo']");
            public static readonly By OurStoryLink = By.CssSelector("[data-at='lnk-footer-our-story']");
            public static readonly By PressLink = By.CssSelector("[data-at='lnk-footer-press']");
            public static readonly By PartnerSignUpLink = By.CssSelector("[data-at='lnk-footer-retailer-sign-up']");
            public static readonly By WeddingPlannerSignUpLink = By.CssSelector("[data-at='lnk-footer-weddingplanner-sign-up']");
            public static readonly By BlogLink = By.CssSelector("[data-at='lnk-footer-blog']");
            public static readonly By ContactUsLink = By.CssSelector("[data-at='lnk-footer-contact-us']");
        }
    }
}
