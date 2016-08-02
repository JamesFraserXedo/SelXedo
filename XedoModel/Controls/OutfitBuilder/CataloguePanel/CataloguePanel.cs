using CommonModel.Controls.OutfitBuilder.CataloguePanel;
using CommonModel.Controls.OutfitBuilder.CataloguePanel.Catalogues;
using Core.Model.TestObjects.Bases;
using ShirtsCatalogue = CommonModel.Controls.OutfitBuilder.CataloguePanel.Catalogues.ShirtsCatalogue;

namespace XedoModel.Controls.OutfitBuilder.CataloguePanel
{
    public class CataloguePanel : BaseCataloguePanel
    {
        public CataloguePanel(TestSettings testSettings) : base(testSettings)
        {
        }

        public TuxedosCatalogue TuxedosCatalogue
        {
            get
            {
                WaitUntilLoaded();
                return new TuxedosCatalogue(TestSettings);
            }
        }

        public NeckwearCatalogue NeckwearCatalogue
        {
            get
            {
                WaitUntilLoaded(); 
                return new NeckwearCatalogue(TestSettings);
            }
        }

        public VestsAndCummerbundsCatalogue VestsCatalogue
        {
            get
            {
                WaitUntilLoaded();
                return new VestsAndCummerbundsCatalogue(TestSettings);
            }
        }

        public ShirtsCatalogue ShirtsCatalogue
        {
            get
            {
                WaitUntilLoaded(); 
                return new ShirtsCatalogue(TestSettings);
            }
        }

        public ShoesCatalogue AccessoriesCatalogue
        {
            get
            {
                WaitUntilLoaded(); 
                return new ShoesCatalogue(TestSettings);
            }
        }
    }
}
