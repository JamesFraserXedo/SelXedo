using CommonModel.Controls.OutfitBuilder.FiltersPanel.Filters.Accessories;
using CommonModel.Controls.OutfitBuilder.FiltersPanel.Filters.Neckwear;
using CommonModel.Controls.OutfitBuilder.FiltersPanel.Filters.Shirts;
using CommonModel.Controls.OutfitBuilder.FiltersPanel.Filters.Suits;
using CommonModel.Controls.OutfitBuilder.FiltersPanel.Filters.Waistcoat;
using Core.Model.TestObjects.Bases;

namespace CommonModel.Controls.OutfitBuilder.FiltersPanel
{
    public abstract class BaseFilterPanel : ControlBase
    {
        protected BaseFilterPanel(TestSettings testSettings) : base(testSettings)
        {
        }

        public abstract BaseSuitsFilter SuitsFilter { get; }

        public abstract BaseNeckwearFilter NeckwearFilter { get; }

        public abstract BaseWaistcoatFilter WaistcoatsFilter { get; }

        public abstract BaseShirtFilter ShirtsFilter { get; }

        public abstract BaseAccessoriesFilter AccessoriesFilter { get; }
    }
}
