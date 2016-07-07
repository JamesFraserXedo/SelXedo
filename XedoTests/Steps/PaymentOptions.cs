using Core.Contexts;
using NUnit.Framework;
using TechTalk.SpecFlow;
using XedoModel.Bases;

namespace XedoTests.Steps
{
    [Binding]
    public class PaymentOptions : XedoStepBase
    {
        public PaymentOptions(Context context) : base(context)
        {
        }

        [Then(@"the groom should be shown the quoted price")]
        public void ThenTheGroomShouldBeShownTheQuotedPrice()
        {
            Assert.IsTrue(PaymentOptionsPage.GroomTotalDue == CurrentContext.UserJourney.GroomOutfitPrice);
        }

        [Then(@"the groom should get his outfit for free")]
        public void ThenTheGroomShouldGetHisOutfitForFree()
        {
            Assert.IsTrue(PaymentOptionsPage.GroomTotalDue == "$0.00");
        }

    }
}
