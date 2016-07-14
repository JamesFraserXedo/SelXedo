using CommonModel.Controls.Common.Footer;
using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace TMLewinModel.Controls.Common.Footer
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
        
        public Link PriceListLink
        {
            get { return new Link(Driver.FindElement(Container, Locators.PriceListLink)); }
        }
        public Link FreeDeliveryAndReturnsLink
        {
            get { return new Link(Driver.FindElement(Container, Locators.FreeDeliveryAndReturnsLink)); }
        }
        
        public new class Locators : SignupFooter.Locators
        {
            public static readonly By Logo = By.CssSelector("[data-at='lnk-footer-logo']");
            public static readonly By PriceListLink = By.CssSelector("[data-at='lnk-footer-pricelist']");
            public static readonly By FreeDeliveryAndReturnsLink = By.CssSelector("[data-at='lnk-footer-menu-freedelivery']");
        }
    }
}
