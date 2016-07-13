using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonModel.Controls.OutfitBuilder.FiltersPanel.Filters;
using CommonModel.Controls.OutfitBuilder.FiltersPanel.Filters.Suits;
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

        public abstract BaseWaistcoatsFilter WaistcoatsFilter { get; }

        public abstract BaseShirtsFilter ShirtsFilter { get; }

        public abstract BaseAccessoriesFilter AccessoriesFilter { get; }
    }
}
