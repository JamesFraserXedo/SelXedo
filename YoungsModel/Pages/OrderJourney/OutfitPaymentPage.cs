using System.Collections.ObjectModel;
using System.Linq;
using CommonModel.Pages.OrderJourney;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using YoungsModel.Controls.OrderJourney;

namespace YoungsModel.Pages.OrderJourney
{
    public class OutfitPaymentPage : BaseOutfitPaymentPage
    {
        public OutfitPaymentPage(TestSettings testSettings) : base(testSettings)
        {
        }

        public PartyPaymentPanel YourOutfitPaymentPanel
        {
            get {return new PartyPaymentPanel(TestSettings, Driver.FindElement(Locators.YourOutfit));}
        }

        public ReadOnlyCollection<PartyPaymentPanel> PartyPaymentPanels
        {
            get
            {
                var containers = Driver.FindElements(Locators.PartyOutfits);
                return containers.Select(o => new PartyPaymentPanel(TestSettings, o)).ToList().AsReadOnly();
            }
        }
    }
}
