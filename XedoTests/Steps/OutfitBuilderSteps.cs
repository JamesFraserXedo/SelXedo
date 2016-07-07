﻿using Core.Contexts;
using Core.Controls.OutfitBuilder.Filters;
using Microsoft.VisualStudio.TestTools.UnitTesting;
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

    }
}
