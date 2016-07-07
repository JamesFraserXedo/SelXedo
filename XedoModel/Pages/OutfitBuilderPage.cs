using Core.Controls.OutfitBuilder;
using Core.Controls.OutfitBuilder.Choosers;
using Core.Controls.OutfitBuilder.Choosers.Accessories;
using Core.Controls.OutfitBuilder.Choosers.Neckwears;
using Core.Controls.OutfitBuilder.Choosers.Shirts;
using Core.Controls.OutfitBuilder.Choosers.Suits;
using Core.Controls.OutfitBuilder.Choosers.Waistcoats;
using Core.Controls.OutfitBuilder.Dummy;
using Core.Controls.OutfitBuilder.Filters;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;
using XedoModel.Controls.OutfitBuilder.Choosers;

namespace XedoModel.Pages
{
    public class OutfitBuilderPage : PageBase
    {
        public OutfitBuilderPage(TestSettings testSettings) : base(testSettings)
        {
            WelcomePopup.Dismiss();
            WaitUntilLoaded();
        }

        public WelcomePopup WelcomePopup
        {
            get { return new WelcomePopup(TestSettings); }
        }

        public OutfitControls OutfitControls
        {
            get { return new OutfitControls(TestSettings); }
        }

        public FilterPanel FilterPanel
        {
            get { return new FilterPanel(TestSettings); }
        }

        public OutfitViewer OutfitViewer
        {
            get { return new OutfitViewer(TestSettings); }
        }

        public ChooserPanel ChooserPanel
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
            get
            {
                return Driver.ElementDisplayed(Locators.ChoicePanelLoading);
            }
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
            public static By PageLoading = By.XPath("//*[@class='outfit-builder ob-loading']");
            public static By ChoicePanelLoading = By.XPath("//*[contains(@class, 'outfit-catalogue-col loading')]");
            
        }
    }
}
