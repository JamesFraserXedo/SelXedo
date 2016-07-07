using Core.Contexts;
using NUnit.Framework;
using TechTalk.SpecFlow;
using XedoModel.Bases;

namespace XedoTests.Steps.LoadTimeSteps
{
    [Binding]
    public class CommonLoadTimeSteps : XedoStepBase
    {
        public CommonLoadTimeSteps(Context context) : base(context)
        {
        }

        [Then(@"the page load time will be less than (.*) seconds")]
        public void ThenThePageLoadTimeWillBeLessThanSeconds(int seconds)
        {
            Assert.IsTrue(CurrentContext.LoadTime.PageContentLoadTime < seconds * 1000,
                "Actual load time was " + CurrentContext.LoadTime.PageContentLoadTime + " ms");
        }

    }
}
