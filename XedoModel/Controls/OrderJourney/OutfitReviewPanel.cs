using CommonModel.Controls.OrderJourney.OutfitReviewPanel;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace XedoModel.Controls.OrderJourney
{
    public class OutfitReviewPanel : UsOutfitReviewPanel
    {
        public OutfitReviewPanel(TestSettings testSettings, IWebElement container) : base(testSettings, container)
        {
        }
    }
}
