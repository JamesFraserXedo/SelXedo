using System;
using Core.CustomElements;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace TMLewinModel.Pages
{
    public class HowItWorksPage : PageBase
    {
        public HowItWorksPage(TestSettings testSettings) : base(testSettings)
        {
        }

        public override bool IsLoaded()
        {
            throw new NotImplementedException();
        }

        public override void SetupState()
        {
            throw new NotImplementedException();
        }

        public Button GetStartedButton
        {
            get { return new Button(Driver.FindElement(Locators.GetStartedButton)); }
        }

        public class Locators
        {
            public static By GetStartedButton = By.CssSelector("[data-at='lnk-get-started']");
        }
    }
}
