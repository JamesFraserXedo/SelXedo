using CommonModel.Controls.Common.Header;
using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace PromGuyModel.Controls.Common.Header
{
    public class Header : MenuHeader
    {
        public Header(TestSettings testSettings) : base(testSettings)
        {
        }

        public Link CollectionsLink
        {
            get { return new Link(Driver.FindElement(Locators.CollectionsLink)); }
        }

        public Link PromotionBanner
        {
            get { return new Link(Driver.FindElement(Locators.PromotionBanner)); }
        }

        public new class Locators : MenuHeader.Locators
        {
            public static readonly By CollectionsLink = By.CssSelector("[data-at='lnk-menu-collections']");
            public static readonly By PromotionBanner = By.CssSelector("[class='free-try-on-message']");
        }
    }
}
