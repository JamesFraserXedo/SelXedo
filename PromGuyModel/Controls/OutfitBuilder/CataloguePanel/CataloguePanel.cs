using CommonModel.Controls.OutfitBuilder.CataloguePanel;
using CommonModel.Controls.OutfitBuilder.CataloguePanel.Catalogues;
using Core.Model.TestObjects.Bases;

namespace PromGuyModel.Controls.OutfitBuilder.CataloguePanel
{
    public class CataloguePanel : BaseCataloguePanel
    {
        public CataloguePanel(TestSettings testSettings) : base(testSettings)
        {
        }

        public TuxedosCatalogue TuxedosCatalogue
        {
            get { return new TuxedosCatalogue(TestSettings); }
        }

        public NeckwearCatalogue NeckwearCatalogue
        {
            get { return new NeckwearCatalogue(TestSettings); }
        }

        public VestsAndCummerbundsCatalogue VestsAndCummerbundsCatalogue
        {
            get { return new VestsAndCummerbundsCatalogue(TestSettings); }
        }

        public ShirtsCatalogue ShirtsCatalogue
        {
            get { return new ShirtsCatalogue(TestSettings); }
        }

        public ShoesCatalogue ShoesCatalogue
        {
            get { return new ShoesCatalogue(TestSettings); }
        }
    }
}
