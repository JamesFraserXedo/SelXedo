using CommonModel.Controls.OutfitSummary.TotalPane;
using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;
using XedoModel.Controls.OutfitBuilder;
using XedoModel.Controls.OutfitBuilder.CataloguePanel;
using XedoModel.Controls.OutfitBuilder.FiltersPanel;

namespace XedoModel.Pages
{
    public class OutfitBuilderPage : PageBase
    {
        public OutfitBuilderPage(TestSettings testSettings) : base(testSettings)
        {
            if (Driver.ElementDisplayed(Locators.ClosePopupButton))
            {
                new Button(Driver.FindElement(Locators.ClosePopupButton)).Click();
            }
            WaitUntilLoaded();
        }

        public FilterPanel FilterPanel
        {
            get
            {
                return new FilterPanel(TestSettings);
            }
        }

        public OutfitControls OutfitControls
        {
            get
            {
                return new OutfitControls(TestSettings);
            }
        }

        public OutfitViewer OutfitViewer
        {
            get
            {
                return new OutfitViewer(TestSettings);
            }
        }

        public CataloguePanel CataloguePanel
        {
            get
            {
                return new CataloguePanel(TestSettings);
            }
        }

        public override bool IsLoaded()
        {
            //return !CataloguePanel.Container.GetParent().GetAttribute("class").Contains("loading");
            return CataloguePanel.IsLoaded;
        }

        public class Locators
        {
            public static readonly By Popup = By.Id("ob-price-information-popup");
            public static readonly By ClosePopupButton = By.Id("close-info-popup");
        }
    }
}
