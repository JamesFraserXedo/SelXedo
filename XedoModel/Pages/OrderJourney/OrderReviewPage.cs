using System.Collections.ObjectModel;
using System.Linq;
using CommonModel.Pages.OrderJourney.OrderReviewPage;
using Core.Model.TestObjects.Bases;
using XedoModel.Controls.OrderJourney;

namespace XedoModel.Pages.OrderJourney
{
    public class OrderReviewPage : UsOrderReviewPage
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
