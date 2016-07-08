using Core.Contexts;
using Core.StepsSupport;
using Core.Utilities;
using TechTalk.SpecFlow;
using TMLewinModel.Bases;

namespace TMLewinTests.Hooks
{
    [Binding]
    class ScenarioHooks : TMLewinStepBase
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
