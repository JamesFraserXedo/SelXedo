using Core.Contexts;
using TechTalk.SpecFlow;
using XedoModel.Bases;

namespace XedoTests.Steps
{
    [Binding]
    public class HomePageSteps : XedoStepBase
    {
        public HomePageSteps(Context context) : base(context)
        {
        }

        [When(@"I click the home page banner lets-get-started button")]
        public void WhenIClickTheHomePageBannerLetsGetStartedButton()
        {
            HomePage.LetsGetStartedButton.Click();
        }

        [When(@"I click the home page collection at index (.*)")]
        public void WhenIClickTheHomePageCollectionAtIndex(int index)
        {
            var collection = HomePage.Collections[index];
            Context.Collection.Name = collection.Name;
            Context.Collection.Price = collection.Price;
            Context.Collection.ImageSource = collection.ImageSource;
            collection.Select();
        }

        [When(@"I click the perfect match get-started button")]
        public void WhenIClickThePerfectMatchGetStartedButton()
        {
            HomePage.PerfectMatchGetStartedButton.Click();
        }

        [When(@"I click the how it works get-started button")]
        public void WhenIClickTheHowItWorksGetStartedButton()
        {
            HomePage.HowItWorksGetStartedButton.Click();
        }
    }
}
