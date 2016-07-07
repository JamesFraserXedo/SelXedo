using Core.Controls.HomePage;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace XedoModel.Pages
{
    public class HomePage : PageBase
    {
        public HomePage(TestSettings testSettings) : base(testSettings)
        {
        }

        public IWebElement HpHeroImage
        {
            get { return Driver.FindElement(Locators.HpHeroImage); }
        }

        //ToDo
        public override bool IsLoaded()
        {
            return Driver.ElementDisplayed(Locators.HpHeroImage);
        }

        public override void SetupState()
        {
            Driver.Navigate().GoToUrl(BaseUrl);
        }

        public PerfectMatchSelector PerfectMatchSelector
        {
            get { return new PerfectMatchSelector(TestSettings); }
        }
        
        public class Locators
        {
            public static By HpHeroImage = By.Id("hp-hero-Image");
            public static By LetsGetStartedButton = By.CssSelector("[data-galabel='Hero-Image-CTA-clicked']");
        }
    }
}
