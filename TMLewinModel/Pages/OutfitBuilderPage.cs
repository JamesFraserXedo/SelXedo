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

        public CataloguePanel CataloguePanel
        {
            get { return new CataloguePanel(TestSettings); }
        }
       
        public override bool IsLoaded()
        {
            return (!PageLoading && Driver.ElementDisplayed(CataloguePanel.Locators.Container));
        }

        public bool PageLoading
        {
            get { return Driver.ElementDisplayed(Locators.PageLoading); }
        }
        
        public override void SetupState()
        {
            Driver.Navigate().GoToUrl(BaseUrl);
        }

        public class Locators
        {
            public static By PageLoading = By.XPath("[class='outfit-builder ob-loading']");
            public static By MessageAlert = By.ClassName("message-alerts message-alert");

        }
    }
}
