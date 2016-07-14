using CommonModel.Pages;
using Core.Model.TestObjects.Bases;
using YoungsModel.Controls.OutfitSummary;
using YoungsModel.Controls.OutfitSummary.OutfitOptions;

namespace YoungsModel.Pages
{
    public class OutfitSummaryPage : BaseOutfitSummaryPage
    {
        public OutfitSummaryPage(TestSettings testSettings) : base(testSettings)
        {
        }

        public SummaryOutfitViewer SummaryOutfitViewer
        {
            get { return new SummaryOutfitViewer(TestSettings); }
        }

        public TotalPanel TotalPanel
        {
            get { return new TotalPanel(TestSettings); }
        }

        public SuitOutfitOption SuitOutfitOption
        {
            get { return new SuitOutfitOption(TestSettings); }
        }

        public WaistcoatOutfitOption WaistcoatOutfitOption
        {
            get { return new WaistcoatOutfitOption(TestSettings); }
        }

        public NeckwearOutfitOption NeckwearOutfitOption
        {
            get { return new NeckwearOutfitOption(TestSettings); }
        }

        public ShirtOutfitOption ShirtOutfitOption
        {
            get { return new ShirtOutfitOption(TestSettings); }
        }

        public AccessoryOutfitOption AccessoryOutfitOption
        {
            get { return new AccessoryOutfitOption(TestSettings); }
        }

        
    }
}
