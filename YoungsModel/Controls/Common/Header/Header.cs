using CommonModel.Controls.Common.Header;
using Core.CustomElements;
using Core.Model.SupportTools;
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
            public static readonly By GroomGoesFreeLink = By.CssSelector("[data-at='lnk-groom-goes-free']");
            public static readonly By PromotionBanner = By.CssSelector("[class='free-try-on-message']");
        }
    }
}
