using System.Threading;
using Core.Contexts;
using Core.Controls.PartyBuilder;
using Core.Model.SupportTools;
using TechTalk.SpecFlow;
using XedoModel.Bases;

namespace XedoTests.Steps
{
    [Binding]
    public class BuildPartySteps : XedoStepBase
    {
        public BuildPartySteps(Context context) : base(context)
        {
        }

        [When(@"I add (.*) additional party members")]
        public void WhenIAddAdditionalPartyMembers(int num)
        {
            for (var i = 0; i < num; i++)
            {
                BuildPartyPage.AddPartyMemberButton.Click();
                Thread.Sleep(1000);
                BuildPartyPage.NewPartyMemberPopup.RoleSelect.SelectByText("Groomsman");
                BuildPartyPage.NewPartyMemberPopup.FirstNameInputBox.SendKeys("First");
                BuildPartyPage.NewPartyMemberPopup.LastNameInputBox.SendKeys("Last");
                BuildPartyPage.NewPartyMemberPopup.OutfitSelect.SelectByIndex(1);
                BuildPartyPage.NewPartyMemberPopup.Submit();
            }
        }

        [When(@"I continue to payment")]
        public void WhenIContinueToPayment()
        {
            BuildPartyPage.ContinueToBillingAddress();
            Thread.Sleep(1000);
            if (Driver.ElementDisplayed(GroomGoesFreePopup.Locators.Container))
            {
                GroomGoesFreePopup.NoThanksButton.Click();
                Driver.WaitForElementToDisappear(GroomGoesFreePopup.Locators.Container);
            }
        }
    }
}
