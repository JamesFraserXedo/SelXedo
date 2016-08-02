using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.OrderJourney.BuildYourParty.OutfitWearersPanel
{
    public class UkWearersPanel : BaseOutfitWearersPanel
    {
        public UkWearersPanel(TestSettings testSettings, IWebElement container) : base(testSettings, container)
        {
        }

        public Button RenameOutfitButton
        {
            get { return new Button(Driver.FindElement(AdultPanel, Locators.RenameButton)); }
        }

        public Button ViewDetailsAndPriceButton
        {
            get { return new Button(Driver.FindElement(_container, Locators.ViewDetailsAndPriceButton)); }
        }

        protected IWebElement IndividualAdultPriceLabel
        {
            get { return Driver.FindElement(AdultPanel, Locators.IndividualPriceLabel); }
        }

        protected IWebElement IndividualChildPriceLabel
        {
            get { return Driver.FindElement(ChildPanel, Locators.IndividualPriceLabel); }
        }

        protected IWebElement AdultOutfitSubTotalLabel
        {
            get { return Driver.FindElement(AdultPanel, Locators.OutfitSubTotalLabel); }
        }

        protected IWebElement ChildOutfitSubTotalLabel
        {
            get { return Driver.FindElement(ChildPanel, Locators.OutfitSubTotalLabel); }
        }

        public string IndividualAdultPrice
        {
            get { return IndividualAdultPriceLabel.Text; }
        }

        public string IndividualChildPrice
        {
            get { return IndividualChildPriceLabel.Text; }
        }

        public int DisplayedAdultWearers
        {
            get { return int.Parse(AdultOutfitSubTotalLabel.Text.Split(' ')[0].Remove(0, 1)); }
        }

        public int DisplayedChildWearers
        {
            get { return int.Parse(ChildOutfitSubTotalLabel.Text.Split(' ')[0].Remove(0, 1)); }
        }

        public string AdultSubtotal
        {
            get { return "£" + AdultOutfitSubTotalLabel.Text.Split('£')[1]; }
        }

        public string ChildSubtotal
        {
            get { return "£" + ChildOutfitSubTotalLabel.Text.Split('£')[1]; }
        }

        public new class Locators : BaseOutfitWearersPanel.Locators
        {
            public static readonly By ViewDetailsAndPriceButton = By.CssSelector("[class*='show-build-party-tux-details-popup-button']");
            public static readonly By IndividualPriceLabel = By.CssSelector("[class='outfit-price-total-amount']");
            public static readonly By OutfitSubTotalLabel = By.CssSelector("[class='outfit-details-combined-amount-price']");
        }
    }
}
