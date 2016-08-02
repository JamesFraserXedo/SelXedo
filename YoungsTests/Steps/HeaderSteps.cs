using Core.Contexts;
using NUnit.Framework;
using TechTalk.SpecFlow;
using YoungsModel.Bases;

namespace YoungsTests.Steps
{
    [Binding]
    public class HeaderSteps : YoungsStepBase
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
