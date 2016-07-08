using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;
using TMLewinModel.Controls.OutfitBuilder;

namespace TMLewinModel.Pages
{
    public class OutfitBuilderPage : PageBase
    {
        public OutfitBuilderPage(TestSettings testSettings) : base(testSettings)
        {
        }
        
        public OutfitControls OutfitControls
        {
            get { return new OutfitControls(TestSettings); }
        }

        public FiltersPanel FiltersPanel
        {
            get { return new FiltersPanel(TestSettings); }
        }

        public OutfitModel OutfitModel
        {
            get { return new OutfitModel(TestSettings); }
        }

        public CataloguePanel ChooserPanel
        {
            get { return new ChooserPanel(TestSettings); }
        }
       
        public override bool IsLoaded()
        {
            return (!PageLoading && !ChoicePanelLoading && Driver.ElementDisplayed(ChooserPanel.Locators.Container));
        }

        public bool PageLoading
        {
            get { return Driver.ElementDisplayed(Locators.PageLoading); }
        }

        public bool ChoicePanelLoading
        {
            get { return ChooserPanel.CurrentChooser.NumberOfItems == 0; }
        }

        public override void SetupState()
        {
            Driver.Navigate().GoToUrl(BaseUrl);
        }

        public ClothingType ActiveClothing
        {
            get { return ChooserPanel.CurrentChooser.ClothingType; }
        }

        public class Locators
        {
            public static By PageLoading = By.XPath("[class='outfit-builder ob-loading']");
            
        }
    }
}
