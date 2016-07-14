using CommonModel.Controls.OutfitSummary;
using Core.Model.TestObjects.Bases;
using PromGuyModel.Controls.OutfitBuilder;

namespace PromGuyModel.Controls.OutfitSummary
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
