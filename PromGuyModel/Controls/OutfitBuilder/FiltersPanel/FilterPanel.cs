using CommonModel.Controls.OutfitBuilder.FiltersPanel;
using CommonModel.Controls.OutfitBuilder.FiltersPanel.Filters.Accessories;
using CommonModel.Controls.OutfitBuilder.FiltersPanel.Filters.Neckwear;
using CommonModel.Controls.OutfitBuilder.FiltersPanel.Filters.Shirts;
using CommonModel.Controls.OutfitBuilder.FiltersPanel.Filters.Suits;
using CommonModel.Controls.OutfitBuilder.FiltersPanel.Filters.Waistcoat;
using Core.Model.TestObjects.Bases;
using PromGuyModel.Controls.OutfitBuilder.FiltersPanel.Filters;

namespace PromGuyModel.Controls.OutfitBuilder.FiltersPanel
{
    public class FilterPanel : ControlBase
    {
        public FilterPanel(TestSettings testSettings) : base(testSettings)
        {
        }

        public SuitFilter SuitsFilter
        {
            get { return new SuitFilter(TestSettings); }
        }

        public NeckwearFilter NeckwearFilter
        {
            get { return new NeckwearFilter(TestSettings); }
        }

        public WaistcoatFilter WaistcoatsFilter
        {
            get { return new WaistcoatFilter(TestSettings); }
        }

        public ShirtsFilter ShirtsFilter
        {
            get { return new ShirtsFilter(TestSettings); }
        }

        public AccessoriesFilter AccessoriesFilter
        {
            get { return new AccessoriesFilter(TestSettings); }
        }
    }
}
