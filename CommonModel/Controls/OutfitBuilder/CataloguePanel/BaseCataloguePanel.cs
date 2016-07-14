using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.OutfitBuilder.CataloguePanel
{
    public abstract class BaseCataloguePanel : ControlBase
    {
        protected BaseCataloguePanel(TestSettings testSettings) : base(testSettings)
        {
        }

        public IWebElement Container
        {
            get { return Driver.FindElement(Locators.Container); }
        }

        public Button PreviousCatalogueButton
        {
            get { return new Button(Driver.FindElement(Container, Locators.PreviousCatalogueButton)); }
        }

        public Button NextCatalogueButton
        {
            get { return new Button(Driver.FindElement(Container, Locators.NextCatalogueButton)); }
        }

        public Button ViewOutfitSummaryButton
        {
            get { return new Button(Driver.FindElement(Container, Locators.ViewOutfitSummaryButton)); }
        }

        public class Locators
        {
            public static By Container = By.ClassName("catalogue-outfit-holder");
            public static By PreviousCatalogueButton = By.ClassName("ob-arrow left");
            public static By NextCatalogueButton = By.ClassName("ob-arrow right");
            public static By ViewOutfitSummaryButton = By.CssSelector("[data-at='lnk-outfit-summary']");
        }
    }
}
