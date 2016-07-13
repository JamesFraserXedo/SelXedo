using CommonModel.Controls.OutfitBuilder.FiltersPanel;
using CommonModel.Controls.OutfitBuilder.FiltersPanel.Filters.Accessories;
using CommonModel.Controls.OutfitBuilder.FiltersPanel.Filters.Neckwear;
using CommonModel.Controls.OutfitBuilder.FiltersPanel.Filters.Shirts;
using CommonModel.Controls.OutfitBuilder.FiltersPanel.Filters.Suits;
using CommonModel.Controls.OutfitBuilder.FiltersPanel.Filters.Waistcoat;
using Core.Model.TestObjects.Bases;
using YoungsModel.Controls.OutfitBuilder.FiltersPanel.Filters;

namespace YoungsModel.Controls.OutfitBuilder.FiltersPanel
{
    public class FilterPanel : BaseFilterPanel
    {
        public FilterPanel(TestSettings testSettings) : base(testSettings)
        {
        }

        public override BaseSuitsFilter SuitsFilter
        {
            get { return new SuitFilter(TestSettings); }
        }

        public override BaseNeckwearFilter NeckwearFilter
        {
            get { return new NeckwearFilter(TestSettings); }
        }

        public override BaseWaistcoatFilter WaistcoatsFilter
        {
            get { return new WaistcoatFilter(TestSettings); }
        }

        public override BaseShirtFilter ShirtsFilter
        {
            get { return new ShirtsFilter(TestSettings); }
        }

        public override BaseAccessoriesFilter AccessoriesFilter
        {
            get { return new AccessoriesFilter(TestSettings); }
        }
    }
}
