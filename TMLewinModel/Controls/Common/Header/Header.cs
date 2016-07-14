using CommonModel.Controls.Common.Header;
using Core.CustomElements;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace TMLewinModel.Controls.Common.Header
{
    public class Header : BurgerBarHeader
    {
        public Header(TestSettings testSettings) : base(testSettings)
        {
        }

        public Link PromotionBanner
        {
            get { return new Link(Driver.FindElement(Locators.PromotionBanner)); }
        }

        public Link ReturnToMainSiteLink
        {
            get { return new Link(Driver.FindElement(Locators.ReturnToMainSiteLink)); }
        }

        public new class Locators : BurgerBarHeader.Locators
        {
            public static readonly By PromotionBanner = By.ClassName("free-try-on-message");
            public static readonly By ReturnToMainSiteLink = By.CssSelector("[data-at='lnk-back-to-main-site']");
        }
    }
}
