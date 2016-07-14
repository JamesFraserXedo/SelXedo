using CommonModel.Controls.Common.Header.NavigationSidebar;
using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace AlfredAngeloModel.Controls.Common.Header
{
    public class NavigationSidebar : BaseNavigationSidebar
    {
        public NavigationSidebar(TestSettings testSettings) : base(testSettings)
        {
        }

        public Button LogoButton
        {
            get { return new Button(Driver.FindElement(Container, Locators.LogoButton)); }
        }

        public Button InspireMeButton
        {
            get { return new Button(Driver.FindElement(Container, Locators.InspireMeButton)); }
        }

        public new class Locators : BaseNavigationSidebar.Locators
        {
            public static readonly By LogoButton = By.CssSelector("[data-at='lnk-menu-logo']");
            public static readonly By InspireMeButton = By.CssSelector("[data-at='lnk-menu-inspired']");
        }
    }
}
