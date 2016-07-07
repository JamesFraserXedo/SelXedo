using System;
using Core.Controls.PartyBuilder;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace XedoModel.Pages.PaymentProcess
{
    public class BuildPartyPage : PageBase
    {
        public BuildPartyPage(TestSettings testSettings) : base(testSettings)
        {
        }

        public IWebElement Container
        {
            get { return Driver.FindElement(Locators.Container); }
        }

        public IWebElement AddPartyMemberButton
        {
            get { return Driver.FindElement(Container, Locators.AddPartyMemberButton); }
        }

        public IWebElement ContinueToBillingAddressButton
        {
            get { return Driver.FindElement(Container, Locators.ContinueToBillingAddressButton); }
        }

        public NewPartyMemberPopup NewPartyMemberPopup
        {
            get { return new NewPartyMemberPopup(TestSettings); }
        }

        public override bool IsLoaded()
        {
            return Driver.ElementDisplayed(Locators.Container);
        }

        public override void SetupState()
        {
            throw new NotImplementedException();
        }

        public void ContinueToBillingAddress()
        {
            ContinueToBillingAddressButton.Click();;
        }

        public class Locators
        {
            public static By Container = By.XPath("//*[@class='content-section-holder']");
            public static By AddPartyMemberButton = By.Id("add-new-wearer-button");
            public static By ContinueToBillingAddressButton = By.Id("saveAndContinueButton");
        }
    }
}
