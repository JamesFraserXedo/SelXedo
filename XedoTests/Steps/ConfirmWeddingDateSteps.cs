using Core.Contexts;
using TechTalk.SpecFlow;
using XedoModel.Bases;

namespace XedoTests.Steps
{
    [Binding]
    public class ConfirmWeddingDateSteps : XedoStepBase
    {
        public ConfirmWeddingDateSteps(Context context) : base(context)
        {
        }

        [Given(@"I have chosen a wedding date")]
        public void GivenIHaveChosenAWeddingDate()
        {
            SelectWeddingDatePage.ConfirmWeddingDateButton.Click();
            SelectWeddingDatePage.ContinueButton.Click();
        }
    }
}
