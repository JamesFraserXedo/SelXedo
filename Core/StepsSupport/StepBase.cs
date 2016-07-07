using Core.Contexts;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace Core.StepsSupport
{
    public class StepBase : Steps
    {
        protected static IWebDriver Driver;
        protected static TestSettings GetTestSettings()
        {
            return new TestSettings(Driver);
        }

        public Context Context;
        public StepBase(Context context)
        {
            Context = context;
        }

        protected const string ContextName = "Context";

        protected static Context CurrentContext
        {
            get { return (Context)ScenarioContext.Current[ContextName]; }
            set { ScenarioContext.Current[ContextName] = value; }
        }
    }
}
