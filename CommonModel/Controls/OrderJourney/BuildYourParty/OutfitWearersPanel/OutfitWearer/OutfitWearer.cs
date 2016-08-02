using System.Collections.ObjectModel;
using System.Linq;
using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.OrderJourney.BuildYourParty.OutfitWearersPanel.OutfitWearer
{
    public class OutfitWearer : ControlBase
    {
        private IWebElement _container;
        public OutfitWearer(TestSettings testSettings, IWebElement container) : base(testSettings)
        {
            _container = container;
        }

        private IWebElement RoleLabel
        {
            get { return Driver.FindElement(_container, Locators.RoleLabel); }
        }

        private IWebElement WearerNameLabel
        {
            get { return Driver.FindElement(_container, Locators.WearerNameLabel); }
        }

        private IWebElement EmailLabel
        {
            get { return Driver.FindElement(_container, Locators.EmailLabel); }
        }

        public Button EditWearerButton
        {
            get { return new Button(Driver.FindElement(_container, Locators.EditWearerButton)); }
        }

        public Button AddSizesButton
        {
            get { return new Button(Driver.FindElement(_container, Locators.AddSizesButton)); }
        }

        public Button EditSizesButton
        {
            get { return new Button(Driver.FindElement(_container, Locators.EditSizesButton)); }
        }

        private ReadOnlyCollection<IWebElement> ItemWrappers
        {
            get { return _container.FindElements(Locators.ItemWrappers); }
        }

        public string Role
        {
            get { return RoleLabel.Text; }
        }

        public string WearerName
        {
            get { return WearerNameLabel.Text; }
        }

        public string Email
        {
            get { return EmailLabel.Text; }
        }

        public bool AllSizesEntered
        {
            get { return Driver.ElementDisplayed(Locators.AllSizesEnteredLabel); }
        }

        public bool SomeSizesEntered
        {
            get { return Driver.ElementDisplayed(Locators.SomeSizesEnteredLabel); }
        }

        public ReadOnlyCollection<ItemSizing> Items
        {
            get
            {
                return ItemWrappers.Select(itemWrapper => new ItemSizing
                {
                    Item = Driver.FindElement(itemWrapper, Locators.ItemName).Text, Size = Driver.FindElement(itemWrapper, Locators.ItemSize).Text
                }).ToList().AsReadOnly();
            }
        }
        public class Locators
        {
            public static readonly By RoleLabel = By.CssSelector("[class='outfit-wearer-head-role']");
            public static readonly By WearerNameLabel = By.CssSelector("[class='outfit-wearer-name-text']");
            public static readonly By EmailLabel = By.CssSelector("[class='outfit-wearer-email']");
            public static readonly By EditWearerButton = By.CssSelector("[class='link blue outfit-wearer-name-edit']");

            public static readonly By AddSizesButton = By.CssSelector("[data-at='click-outfit-wearer-sizes-select-addsizes']");
            public static readonly By EditSizesButton = By.CssSelector("[class='link blue outfit-wearer-name-edit enter-sizing-info outfit-sizing-link']");

            public static readonly By AllSizesEnteredLabel = By.CssSelector("[class='message-alerts message-success']");
            public static readonly By SomeSizesEnteredLabel = By.CssSelector("[class='message-alerts message-warning']");

            public static readonly By ItemWrappers = By.CssSelector("[class='sizing-overview']");
            public static readonly By ItemName = By.CssSelector("[class='sizing-overview-name']");
            public static readonly By ItemSize = By.CssSelector("[class='sizing-overview-value']");
        }

        public class ItemSizing
        {
            public string Item { get; set; }
            public string Size { get; set; }
    }
    }
}
