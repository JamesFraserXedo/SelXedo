using Core.Model.TestObjects.Bases;
using PromGuyModel.Controls.OutfitBuilder.CataloguePanel.Catalogues;

namespace PromGuyModel.Controls.OutfitBuilder.CataloguePanel
{
    public class CataloguePanel : ControlBase
    {
        public CataloguePanel(TestSettings testSettings) : base(testSettings)
        {
        }

        public SuitsCatalogue SuitsCatalogue
        {
            get { return new SuitsCatalogue(TestSettings); }
        }

        public NeckwearCatalogue NeckwearCatalogue
        {
            get { return new NeckwearCatalogue(TestSettings); }
        }

        public WaistcoatsCatalogue WaistcoatsCatalogue
        {
            get { return new WaistcoatsCatalogue(TestSettings); }
        }

        public ShirtsCatalogue ShirtsCatalogue
        {
            get { return new ShirtsCatalogue(TestSettings); }
        }

        public AccessoriesCatalogue AccessoriesCatalogue
        {
            get { return new AccessoriesCatalogue(TestSettings); }
        }
    }
}
