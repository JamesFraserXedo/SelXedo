using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.OrderJourney.BuildYourParty.OutfitWearersPanel
{
    public class UsWearersPanel : BaseOutfitWearersPanel
    {
        public UsWearersPanel(TestSettings testSettings, IWebElement container) : base(testSettings, container)
        {
        }

        public Button RenameTuxButton
        {
            get { return new Button(Driver.FindElement(AdultPanel, Locators.RenameButton)); }
        }

        public Button AdultViewDetailsAndPriceButton
        {
            get { return new Button(Driver.FindElement(AdultPanel, Locators.ViewDetailsAndPriceButton)); }
        }

        public Button ChildViewDetailsAndPriceButton
        {
            get { return new Button(Driver.FindElement(ChildPanel, Locators.ViewDetailsAndPriceButton)); }
        }

        public new class Locators : BaseOutfitWearersPanel.Locators
        {
            public static readonly By ViewDetailsAndPriceButton = By.CssSelector("[class*='show-build-party-tux-details-popup-button']");
        }
    }
}
