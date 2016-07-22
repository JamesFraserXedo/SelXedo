using Core.Contexts;
using Core.StepsSupport;
using Core.Utilities;
using TechTalk.SpecFlow;
using YoungsModel.Bases;

namespace YoungsTests.Hooks
{
    [Binding]
    class ScenarioHooks : YoungsStepBase
    {
        public ScenarioHooks(Context context) : base(context)
        {
        }

        [BeforeScenario]
        private void BeforeScenario()
        {
            ScenarioContext.Current[ContextName] = new Context();
            Driver = WebDriverFactory.Get();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            TestFinaliser.TearDown();
        }
    }
}
