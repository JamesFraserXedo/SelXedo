using Core.Contexts;
using NUnit.Framework;
using TechTalk.SpecFlow;
using YoungsModel.Bases;

namespace YoungsTests.Steps
{
    [Binding]
    public class RegistrationSteps : YoungsStepBase
    {
        public RegistrationSteps(Context context) : base(context)
        {
        }

        [Then(@"I am on the registration page")]
        public void ThenIAmOnTheRegistrationPage()
        {
            RegistrationPage.WaitUntilLoaded();
            Assert.That(RegistrationPage.IsLoaded);
        }

    }
}
