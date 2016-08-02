using System.Linq;
using System.Threading;
using Core.Contexts;
using TechTalk.SpecFlow;
using XedoModel.Bases;

namespace XedoTests.Steps
{
    [Binding]
    public class OutfitBuilderSteps : XedoStepBase
    {
        public OutfitBuilderSteps(Context context) : base(context)
        {
        }

        [When(@"I select a suit")]
        public void WhenISelectASuit()
        {
            OutfitBuilderPage.FilterPanel.SuitsFilter.Select();
            OutfitBuilderPage.CataloguePanel.TuxedosCatalogue.Tuxedos.First().Select();
        }
        
        [When(@"I select neckwear")]
        public void WhenISelectNeckwear()
        {
            OutfitBuilderPage.FilterPanel.NeckwearFilter.Select();
            OutfitBuilderPage.CataloguePanel.NeckwearCatalogue.Neckwear.First().Select();
        }

        [When(@"I proceed to the outfit summary")]
        public void WhenIProceedToTheOutfitSummary()
        {
            OutfitBuilderPage.CataloguePanel.ViewOutfitSummaryButton.Click();
            OutfitSummaryPage.WaitUntilLoaded();
            Thread.Sleep(10000);
        }

    }
}
