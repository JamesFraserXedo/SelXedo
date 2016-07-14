using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using TMLewinModel.Controls.OutfitBuilder;
using TMLewinModel.Controls.OutfitBuilder.CataloguePanel;
using TMLewinModel.Controls.OutfitBuilder.FiltersPanel;

namespace TMLewinModel.Pages
{
    public class OutfitBuilderPage : PageBase
    {
        public OutfitBuilderPage(TestSettings testSettings) : base(testSettings)
        {
        }

        public FilterPanel FilterPanel
        {
            get { return new FilterPanel(TestSettings); }
        }

        public OutfitControls OutfitControls
        {
            get { return new OutfitControls(TestSettings); }
        }

        public OutfitViewer OutfitViewer
        {
            get { return new OutfitViewer(TestSettings); }
        }

        public CataloguePanel CataloguePanel
        {
            get { return new CataloguePanel(TestSettings); }
        }

        public override bool IsLoaded()
        {
            return !CataloguePanel.Container.GetParent().GetAttribute("class").Contains("loading");
        }
    }
}
