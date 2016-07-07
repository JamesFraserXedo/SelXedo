using Core.Contexts;
using TechTalk.SpecFlow;
using XedoModel.Bases;

namespace XedoTests.Steps.SharedSteps
{
    [Binding]
    public sealed class ExclusiveAccessPageSteps : XedoStepBase
    {
        public ExclusiveAccessPageSteps(Context context) : base(context)
        {
        }

        [When(@"I enter ""(.*)"" into the exclusive access password box")]
        public void WhenIEnterIntoTheExclusiveAccessPasswordBox(string password)
        {
            ExclusiveAccessPage.InputPassword(password);
        }

        [When(@"I click the exclusive access submit button")]
        public void WhenIClickTheExclusiveAccessSubmitButton()
        {
            ExclusiveAccessPage.SubmitPasswordButton.Click();
        }
    }
}
