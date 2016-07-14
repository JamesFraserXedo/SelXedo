using AlfredAngeloModel.Controls.OutfitBuilder;
using CommonModel.Controls.OutfitSummary;
using Core.Model.TestObjects.Bases;

namespace AlfredAngeloModel.Controls.OutfitSummary
{
    public class SummaryOutfitViewer : BaseSummaryOutfitViewer
    {
        protected SummaryOutfitViewer(TestSettings testSettings) : base(testSettings)
        {
        }

        public OutfitViewer OutfitViewer
        {
            get { return new OutfitViewer(TestSettings); }
        }
    }
}
