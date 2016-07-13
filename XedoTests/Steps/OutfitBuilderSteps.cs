using System.Diagnostics;
using Core.Contexts;
using NUnit.Framework;
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
        /*
        

        [Given(@"I am on the outfit builder page")]
        public void GivenIAmOnTheOutfitBuilderPage()
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            Driver.Navigate().GoToUrl("https://uat-xedo-usa.azurewebsites.net/outfitbuilder/build");
            CurrentContext.LoadTime.PageLoadTime = stopwatch.ElapsedMilliseconds;

            if (ExclusiveAccessPage.OnPage)
            {
                ExclusiveAccessPage.InputPassword("atlanta123");
                ExclusiveAccessPage.Submit();
                stopwatch.Restart();
            }

            //OutfitBuilderPage.WaitUntilLoaded();

            stopwatch.Stop();
            CurrentContext.LoadTime.PageContentLoadTime = stopwatch.ElapsedMilliseconds;
        }

        [When(@"I go to the home page")]
        public void WhenIGoToTheHomePage()
        {
            ScenarioContext.Current.Pending();
        }


        [Then(@"I am on the outfit builder page")]
        public void ThenIAmOnTheOutfitBuilderPage()
        {
            Assert.IsTrue(Driver.Url.Contains("/outfitbuilder"));
        }


        [Then(@"the neckwear filter is expanded")]
        public void ThenTheNeckwearFilterIsExpanded()
        {
            Assert.IsTrue(OutfitBuilderPage.ActiveClothing == ClothingType.Neckwear);
        }

        [Then(@"the colour (.*) filter is selected")]
        public void ThenTheColourFilterIsSelected(string colour)
        {
            colour = colour.ToLower();
            if (colour == "grey") { colour = "gray"; }
            switch (OutfitBuilderPage.ActiveClothing)
            {
                case ClothingType.Suit:
                    Assert.IsTrue(OutfitBuilderPage.FilterPanel.SuitsFilter.ColourFilter.SelectedColour.ToLower() == colour);
                    break;
                case ClothingType.Neckwear:
                    Assert.IsTrue(OutfitBuilderPage.FilterPanel.NeckwearFilter.ColourFilter.SelectedColour.ToLower() == colour);
                    break;
                case ClothingType.Waistcoat:
                    Assert.IsTrue(OutfitBuilderPage.FilterPanel.WaistcoatFilter.ColourFilter.SelectedColour.ToLower() == colour);
                    break;
                default:
                    Assert.IsTrue(false, "Not on a filter with a colour chooser");
                    break;
            }
        }

        [Given(@"I have added an outfit to my order")]
        public void GivenIHaveAddedAnOutfitToMyOrder()
        {
            OutfitBuilderPage.ChooserPanel.SuitChooser.Items[0].Select();
            OutfitBuilderPage.ChooserPanel.OutfitSummaryButton.Click();

            CurrentContext.UserJourney.GroomOutfitPrice = OutfitSummaryPage.TotalDue;

            OutfitSummaryPage.AddToOrderButton.Click();
        }

    
         */
    }
}
