using System.Diagnostics;
using Core.Contexts;
using Core.StepsSupport;
using TechTalk.SpecFlow;
using TMLewinModel.Bases;

namespace TMLewinTests.Steps
{
    [Binding]
    public class HomePageSteps : TMLewinStepBase
    {
        public HomePageSteps(Context context) : base(context)
        {
        }

        [Given(@"I am on the home page")]
        public void GivenIAmOnTheHomePage()
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            Driver.Navigate().GoToUrl(TestsConfig.BaseUrl);
            CurrentContext.LoadTime.PageLoadTime = stopwatch.ElapsedMilliseconds;

            if (ExclusiveAccessPage.OnPage)
            {
                ExclusiveAccessPage.InputPassword("atlanta123");
                ExclusiveAccessPage.Submit();
                stopwatch.Restart();
            }

            HomePage.WaitUntilLoaded();
            stopwatch.Stop();
            CurrentContext.LoadTime.PageContentLoadTime = stopwatch.ElapsedMilliseconds;
        }
    }
}
