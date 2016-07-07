using System.Diagnostics;
using Core.Contexts;
using TechTalk.SpecFlow;
using XedoModel.Bases;

namespace XedoTests.Steps.SharedSteps
{
    [Binding]
    public class CommonSteps : XedoStepBase
    {
        public CommonSteps(Context context) : base(context)
        {
        }

        [Given(@"I am on the home page")]
        public void GivenIAmOnTheSite()
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            Driver.Navigate().GoToUrl("https://uat-xedo-usa.azurewebsites.net/");
            CurrentContext.LoadTime.PageLoadTime = stopwatch.ElapsedMilliseconds;

            if (ExclusiveAccessPage.OnPage)
            {
                ExclusiveAccessPage.InputPassword("atlanta123");
                ExclusiveAccessPage.Submit();
            }

            stopwatch.Stop();
            CurrentContext.LoadTime.PageContentLoadTime = stopwatch.ElapsedMilliseconds;

        }
    }
}
