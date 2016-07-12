using CommonModel.Controls.Common.Header.NavigationSidebar;
using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace TMLewinModel.Controls.Common.Header
{
    public class NavigationSidebar : BaseNavigationSidebar
    {
        public NavigationSidebar(TestSettings testSettings) : base(testSettings)
        {
        }

        public Button FreeDeliveryAndReturnsButton
        {
            get { return new Button(Driver.FindElement(Container, Locators.FreeDeliveryAndReturnsButton)); }
        }

        public new class Locators : BaseNavigationSidebar.Locators
        {
            public static By FreeDeliveryAndReturnsButton = By.CssSelector("[data-at='lnk-menu-freedelivery']");
        }
    }
}
