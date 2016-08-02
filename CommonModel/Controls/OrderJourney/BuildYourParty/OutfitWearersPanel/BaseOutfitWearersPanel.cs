using System.Collections.ObjectModel;
using System.Linq;
using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.OrderJourney.BuildYourParty.OutfitWearersPanel
{
    public abstract class BaseOutfitWearersPanel : ControlBase
    {
        protected IWebElement _container;
        protected BaseOutfitWearersPanel(TestSettings testSettings, IWebElement container) : base(testSettings)
        {
            _container = container;
        }

        protected IWebElement AdultPanel
        {
            get { return Driver.FindElement(_container, Locators.AdultPanel); }
        }

        protected IWebElement ChildPanel
        {
            get { return Driver.FindElement(_container, Locators.ChildPanel); }
        }

        protected IWebElement OutfitNameLabel
        {
            get { return Driver.FindElement(_container, Locators.OutfitNameLabel); }
        }

        protected ReadOnlyCollection<IWebElement> AdultOutfitItemLabels
        {
            get { return AdultPanel.FindElements(Locators.OutfitItemLabels); }
        }

        public Button AddAdultWearerButton
        {
            get { return new Button(Driver.FindElement(AdultPanel, Locators.AddWearerButton)); }
        }

        protected ReadOnlyCollection<IWebElement> ChildOutfitItemLabels
        {
            get { return ChildPanel.FindElements(Locators.OutfitItemLabels); }
        }

        public ReadOnlyCollection<OutfitWearer.OutfitWearer> AdultOutfitWearers
        {
            get
            {
                var elements = AdultPanel.FindElements(Locators.OutfitWearers);
                return elements.Select(o => new OutfitWearer.OutfitWearer(TestSettings, o)).ToList().AsReadOnly();
            }
        }

        public ReadOnlyCollection<OutfitWearer.OutfitWearer> ChildOutfitWearers
        {
            get
            {
                var elements = ChildPanel.FindElements(Locators.OutfitWearers);
                return elements.Select(o => new OutfitWearer.OutfitWearer(TestSettings, o)).ToList().AsReadOnly();
            }
        }

        public Button AddChildWearerButton
        {
            get { return new Button(Driver.FindElement(ChildPanel, Locators.AddWearerButton)); }
        }

        public string OutfitName
        {
            get { return OutfitNameLabel.Text; }
        }

        public ReadOnlyCollection<string> AdultOutfitItems
        {
            get { return AdultOutfitItemLabels.Select(outfitItemLabel => outfitItemLabel.Text).ToList().AsReadOnly(); }
        }

        public ReadOnlyCollection<string> ChildOutfitItems
        {
            get { return ChildOutfitItemLabels.Select(outfitItemLabel => outfitItemLabel.Text).ToList().AsReadOnly(); }
        } 

        public class Locators
        {
            public static readonly By OutfitWearers = By.CssSelector("[data-wearer-id]:not([data-wearer-id=''])");
            public static readonly By OutfitNameLabel = By.CssSelector("[class='outfit-name-details-outfitname']");
            public static readonly By RenameButton = By.CssSelector("[class='link blue outfit-name-edit']");
            public static readonly By AdultPanel = By.CssSelector("[class='adult-outfit']");
            public static readonly By ChildPanel = By.CssSelector("[class='child-outfit']");
            public static readonly By OutfitItemLabels = By.CssSelector("[class='outfit-info-items-list']>li");
            public static readonly By AddWearerButton = By.CssSelector("[class='outfit-add-wearer-button']");
        }
    }
}
