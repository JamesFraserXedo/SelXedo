using Core.Model.TestObjects.Bases;

namespace CommonModel.Controls.OutfitBuilder.CataloguePanel
{
    public abstract class BaseCataloguePanel : ControlBase
    {
        protected BaseCataloguePanel(TestSettings testSettings) : base(testSettings)
        {
        }

        public abstract BaseSuitsCatalogue SuitsCatalogue { get; }

        public abstract BaseNeckwearCatalogue NeckwearCatalogue { get; }

        public abstract BaseWaistcoatCatalogue WaistcoatsCatalogue { get; }

        public abstract BaseShirtCatalogue ShirtsCatalogue { get; }

        public abstract BaseAccessoriesCatalogue AccessoriesCatalogue { get; }
    }
}
