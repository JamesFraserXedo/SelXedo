using Core.Contexts;
using TechTalk.SpecFlow;
using XedoModel.Bases;

namespace XedoTests.Steps
{
    [Binding]
    public class ColourMatchSteps : XedoStepBase
    {
        public ColourMatchSteps(Context context) : base(context)
        {
        }

        [When(@"I choose to colour match black")]
        public void IChooseToColourMatchBlack()
        {
            HomePage.ColourMatch.Black.Click();
        }

        [When(@"I choose to colour match teal")]
        public void IChooseToColourMatchTeal()
        {
            HomePage.ColourMatch.Teal.Click();
        }

        [When(@"I choose to colour match blue")]
        public void IChooseToColourMatchBlue()
        {
            HomePage.ColourMatch.Blue.Click();
        }

        [When(@"I choose to colour match green")]
        public void IChooseToColourMatchGreen()
        {
            HomePage.ColourMatch.Green.Click();
        }

        [When(@"I choose to colour match purple")]
        public void IChooseToColourMatchPurple()
        {
            HomePage.ColourMatch.Purple.Click();
        }

        [When(@"I choose to colour match gray")]
        public void IChooseToColourMatchGray()
        {
            HomePage.ColourMatch.Gray.Click();
        }

        [When(@"I choose to colour match red")]
        public void IChooseToColourMatchRed()
        {
            HomePage.ColourMatch.Red.Click();
        }

        [When(@"I choose to colour match tan")]
        public void IChooseToColourMatchTan()
        {
            HomePage.ColourMatch.Tan.Click();
        }

        [When(@"I choose to colour match pink")]
        public void IChooseToColourMatchPink()
        {
            HomePage.ColourMatch.Pink.Click();
        }

        [When(@"I choose to colour match yellow")]
        public void IChooseToColourMatchYellow()
        {
            HomePage.ColourMatch.Yellow.Click();
        }

        [When(@"I choose to colour match ivory")]
        public void IChooseToColourMatchIvory()
        {
            HomePage.ColourMatch.Ivory.Click();
        }

    }
}
