using Core.Contexts;
using Core.StepsSupport;
using Core.Utilities;
using PromGuyModel.Bases;
using TechTalk.SpecFlow;

namespace PromGuyTests.Hooks
{
    [Binding]
    class ScenarioHooks : PromGuyStepBase
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
