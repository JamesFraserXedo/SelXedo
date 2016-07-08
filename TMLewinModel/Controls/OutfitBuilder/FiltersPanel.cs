using Core.Model.TestObjects.Bases;
using TMLewinModel.Controls.OutfitBuilder.Filters;

namespace TMLewinModel.Controls.OutfitBuilder
{
    public class FiltersPanel : ControlBase
    {
        public FiltersPanel(TestSettings testSettings) : base(testSettings)
        {
        }

        public SuitsFilter SuitsFilter
        {
            get { return new SuitsFilter(TestSettings); }
        }

        public NeckwearFilter NeckwearFilter
        {
            get { return new NeckwearFilter(TestSettings); }
        }

        public WaistcoatsFilter WaistcoatsFilter
        {
            get { return new WaistcoatsFilter(TestSettings); }
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
