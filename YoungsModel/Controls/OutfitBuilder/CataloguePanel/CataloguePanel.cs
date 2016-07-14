﻿using CommonModel.Controls.OutfitBuilder.CataloguePanel;
using Core.Model.TestObjects.Bases;
using YoungsModel.Controls.OutfitBuilder.CataloguePanel.Catalogues;

namespace YoungsModel.Controls.OutfitBuilder.CataloguePanel
{
    public class CataloguePanel : BaseCataloguePanel
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
