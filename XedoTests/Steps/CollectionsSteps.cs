using System.Linq;
using Core.Contexts;
using TechTalk.SpecFlow;
using XedoModel.Bases;

namespace XedoTests.Steps
{
    [Binding]
    public class CollectionsSteps : XedoStepBase
    {
        public CollectionsSteps(Context context) : base(context)
        {
        }

        [When(@"I select a collection outfit")]
        public void WhenISelectACollectionOutfit()
        {
            CollectionsPage.Outfits.First().Select();
        }
    }
}
