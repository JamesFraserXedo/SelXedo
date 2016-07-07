using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace Core.Controls.PartyBuilder
{
    public class GroomGoesFreePopup : ControlBase
    {
        public GroomGoesFreePopup(TestSettings testSettings) : base(testSettings)
        {
        }

        public IWebElement Container
        {
            get { return Driver.FindElement(Locators.Container); }
        }

        public IWebElement NoThanksButton
        {
            get { return Driver.FindElement(Container, Locators.NoThanksButton); }
        }

        public class Locators
        {
            public static By Container = By.Id("GGFDiscountPromptPopup");
            public static By NoThanksButton = By.Id("buildPartyGGFPopUpNoThanksBtn");
        }
    }

   
}
