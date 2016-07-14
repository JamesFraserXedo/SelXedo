using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.OutfitSummary
{
    public abstract class BaseSummaryOutfitViewer : ControlBase
    {
        protected BaseSummaryOutfitViewer(TestSettings testSettings) : base(testSettings)
        {
        }

        public IWebElement Container
        {
            get { return Driver.FindElement(Locators.Container); }
        }

        public Button CustomiseButton
        {
            get { return new Button(Driver.FindElement(Container, Locators.CustomiseButton)); }
        }

        public Button HideJacketButton
        {
            get { return new Button(Driver.FindElement(Container, Locators.HideJacketButton)); }
        }

        public Button SaveToFavouritesButton
        {
            get { return new Button(Driver.FindElement(Container, Locators.SaveToFavouritesButton)); }
        }

        public class Locators
        {
            public static readonly By Container = By.CssSelector("");
            public static readonly By CustomiseButton = By.CssSelector("div>a");
            public static readonly By HideJacketButton = By.CssSelector("[data-at='lnk-remove-jacket']");
            public static readonly By SaveToFavouritesButton = By.CssSelector("[data-at='lnk-save-outfit']");
        }
    }
}
