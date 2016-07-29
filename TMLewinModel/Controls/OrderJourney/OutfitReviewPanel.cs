using CommonModel.Controls.OrderJourney.OutfitReviewPanel;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace TMLewinModel.Controls.OrderJourney
{
    public class OutfitReviewPanel : UkOutfitReviewPanel
    {
        public OutfitReviewPanel(TestSettings testSettings, IWebElement container) : base(testSettings, container)
        {
        }
    }
}
