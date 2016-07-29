using System.Collections.ObjectModel;
using System.Linq;
using AlfredAngeloModel.Controls.OrderJourney;
using CommonModel.Pages.OrderJourney.OrderReviewPage;
using Core.Model.TestObjects.Bases;

namespace AlfredAngeloModel.Pages.OrderJourney
{
    public class OrderReviewPage : UkOrderReviewPage
    {
        public OrderReviewPage(TestSettings testSettings) : base(testSettings)
        {
        }

        public ReadOnlyCollection<OutfitReviewPanel> OutfitReviewPanels
        {
            get
            {
                var elements = Driver.FindElements(Locators.OutfitReviewPanels);
                return elements.Select(e => new OutfitReviewPanel(TestSettings, e)).ToList().AsReadOnly();
            }
        } 
    }
}
