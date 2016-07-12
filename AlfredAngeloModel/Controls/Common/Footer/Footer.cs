using CommonModel.Controls.Common.Footer;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace AlfredAngeloModel.Controls.Common.Footer
{
    public class Footer : BaseFooter
    {
        public Footer(TestSettings testSettings) : base(testSettings)
        {
        }

        public IWebElement Logo
        {
            get { return Driver.FindElement(Container, Locators.Logo); }
        }
        
        public new class Locators : BaseFooter.Locators
        {
            public static By Logo = By.CssSelector("[data-at='lnk-footer-logo']");
        }
    }
}
