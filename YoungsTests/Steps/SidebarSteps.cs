using Core.Contexts;
using TechTalk.SpecFlow;
using YoungsModel.Bases;

namespace YoungsTests.Steps
{
    [Binding]
    public class SidebarSteps : YoungsStepBase
    {
        public SidebarSteps(Context context) : base(context)
        {
        }

        [When(@"I click the register now link in the sidebar")]
        public void WhenIClickTheRegisterNowLinkInTheSidebar()
        {
            Header.SignInButton.Click();
            LoginSidebar.RegisterLink.Click();
        }
    }
}
