using Core.Contexts;
using NUnit.Framework;
using TechTalk.SpecFlow;
using XedoModel.Bases;

namespace XedoTests.Steps.SharedSteps
{
    [Binding]
    public class HeaderSteps : XedoStepBase
    {
        public HeaderSteps(Context context) : base(context)
        {
        }

        [When(@"I click the login button in the header")]
        public void WhenIClickTheLoginButtonInTheHeader()
        {
            Header.SignInButton.Click();
        }

        [Then(@"the login panel should be open")]
        public void ThenTheLoginPanelShouldBeOpen()
        {
            Assert.IsTrue(LoginSidebar.Expanded);
        }
    }
}
