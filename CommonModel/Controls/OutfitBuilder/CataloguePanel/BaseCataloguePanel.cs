using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace CommonModel.Controls.OutfitBuilder.CataloguePanel
{
    public abstract class BaseCataloguePanel : ControlBase
    {
        protected BaseCataloguePanel(TestSettings testSettings) : base(testSettings)
        {
        }

        public void WaitUntilLoaded()
        {
            var s = new Stopwatch();
            s.Start();

            while (s.Elapsed < TimeSpan.FromSeconds(30))
            {
                if (IsLoaded)
                {
                    return;
                }
                Thread.Sleep(1000);
            }
            throw new TimeoutException(string.Format("The page did not load within {0} seconds", 30));
        }
        
        public bool IsLoaded
        {
            get { return !Container.GetParent().GetAttribute("class").Contains("loading"); }
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
            public static readonly By Container = By.CssSelector("[class='catalogue-outfit-holder']");
            public static readonly By PreviousCatalogueButton = By.CssSelector("[class='ob-arrow left']");
            public static readonly By NextCatalogueButton = By.CssSelector("[class='ob-arrow right']");
            public static readonly By ViewOutfitSummaryButton = By.CssSelector("[data-at='lnk-outfit-summary']");
        }
    }
}
