using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.Common.Header
{
    public abstract class BurgerBarHeader : BaseHeader
    {
        protected BurgerBarHeader(TestSettings testSettings) : base(testSettings)
        {
        }

        public Button HeaderImage
        {
            get { return new Button(Driver.FindElement(Locators.HeaderImage)); }
        }

        public Button BurgerMenu
        {
            get { return new Button(Driver.FindElement(Locators.BurgerMenu)); }
        }

        public new class Locators : BaseHeader.Locators
        {
            public static readonly By HeaderImage = By.CssSelector("[data-at='lnk-header-image']");
            public static readonly By BurgerMenu = By.CssSelector("[data-at='lnk-main-menu']");
        }
    }
}
