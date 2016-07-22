using AlfredAngeloModel.Bases;
using Core.Contexts;
using Core.StepsSupport;
using Core.Utilities;
using TechTalk.SpecFlow;

namespace AlfredAngeloTests.Hooks
{
    [Binding]
    class ScenarioHooks : AlfredAngeloStepBase
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
