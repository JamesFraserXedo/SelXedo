using CommonModel.Controls.Common.Header;
using Core.CustomElements;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace YoungsModel.Controls.Common.Header
{
    public class Header : MenuHeader
    {
        public Header(TestSettings testSettings) : base(testSettings)
        {
        }

        public Link GroomGoesFreeLink
        {
            get { return new Link(Driver.FindElement(Locators.GroomGoesFreeLink)); }
        }

        public Link PromotionBanner
        {
            get { return new Link(Driver.FindElement(Locators.PromotionBanner)); }
        }

        public new class Locators : MenuHeader.Locators
        {
            public static By GroomGoesFreeLink = By.CssSelector("[data-at='lnk-groom-goes-free']");
            public static By PromotionBanner = By.ClassName("free-try-on-message");
        }
    }
}
