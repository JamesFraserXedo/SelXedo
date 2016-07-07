using Core.Contexts;
using TechTalk.SpecFlow;
using XedoModel.Bases;

namespace XedoTests.Steps.SharedSteps
{
    [Binding]
    public class SidebarSteps : XedoStepBase
    {
        public SidebarSteps(Context context) : base(context)
        {
        }

        [When(@"I click the register now link in the sidebar")]
        public void WhenIClickTheRegisterNowLinkInTheSidebar()
        {
            Header.OpenLoginPanelButton.Click();
            LoginForm.RegisterLink.Click();
        }
    }
}
