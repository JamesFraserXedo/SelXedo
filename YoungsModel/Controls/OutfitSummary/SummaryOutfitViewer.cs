using CommonModel.Controls.OutfitSummary;
using Core.Model.TestObjects.Bases;
using YoungsModel.Controls.OutfitBuilder;

namespace YoungsModel.Controls.OutfitSummary
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
