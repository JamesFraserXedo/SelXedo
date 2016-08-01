using System.Collections.ObjectModel;
using System.Linq;
using CommonModel.Controls.OrderJourney.BuildYourParty.OutfitWearersPanel;
using Core.Model.TestObjects.Bases;

namespace CommonModel.Pages.OrderJourney.BuildYourPartyPage
{
    public abstract class UsBuildYourPartyPage : BaseBuildYourPartyPage
    {
        protected UsBuildYourPartyPage(TestSettings testSettings) : base(testSettings)
        {
        }

        public ReadOnlyCollection<UsWearersPanel> WearerPanels
        {
            get { return OutfitWearerPanelElements.Select(element => new UsWearersPanel(TestSettings, element)).ToList().AsReadOnly(); }
        }
    }
}
