using System.Collections.Generic;
using System.Collections.ObjectModel;
using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.OrderJourney.OutfitReviewPanel
{
    public abstract class BaseOutfitReviewPanel : ControlBase
    {
        protected IWebElement _container;
        protected BaseOutfitReviewPanel(TestSettings testSettings, IWebElement container) : base(testSettings)
        {
            _container = container;
        }

        protected IWebElement NameLabel
        {
            get { return Driver.FindElement(_container, Locators.NameLabel); }
        }

        protected IWebElement EmailLabel
        {
            get { return Driver.FindElement(_container, Locators.EmailLabel); }
        }

        public Link EditPartyMemberLink
        {
            get { return new Link(Driver.FindElement(_container, Locators.EditPartyMemberLink)); }
        }

        protected IWebElement RoleLabel
        {
            get { return Driver.FindElement(_container, Locators.RoleLabel); }
        }

        protected IWebElement OutfitNameLabel
        {
            get { return Driver.FindElement(_container, Locators.OutfitNameLabel); }
        }

        protected IWebElement DeliveryAddressLabel
        {
            get { return Driver.FindElement(_container, Locators.DeliveryAddressLabel); }
        }

        protected IWebElement DeliveryDateLabel 
        {
            get { return Driver.FindElement(_container, Locators.DeliveryDateLabel); }
        }

        protected IWebElement ReturnAddressLabel
        {
            get { return Driver.FindElement(_container, Locators.ReturnAddressLabel); }
        }

        protected IWebElement ReturnDateLabel
        {
            get { return Driver.FindElement(_container, Locators.ReturnDateLabel); }
        }

        protected ReadOnlyCollection<IWebElement> GarmentElements
        {
            get { return _container.FindElements(Locators.AllGarments); }
        }

        public string Name
        {
            get { return NameLabel.Text; }
        }

        public string Email
        {
            get { return EmailLabel.Text; }
        }

        public string Role
        {
            get { return RoleLabel.Text; }
        }

        public string OutfitName
        {
            get { return OutfitNameLabel.Text; }
        }

        public string DeliveryAddress
        {
            get { return DeliveryAddressLabel.Text; }
        }

        public string DeliveryDate
        {
            get { return DeliveryDateLabel.Text; }
        }

        public string ReturnAddress
        {
            get { return ReturnAddressLabel.Text; }
        }

        public string ReturnDate
        {
            get { return ReturnDateLabel.Text; }
        }

        public ReadOnlyCollection<Garment> Garments
        {
            get
            {
                var list = new List<Garment>();
                foreach (var garmentElement in GarmentElements)
                {
                    var garment = new Garment
                    {
                        Name = Driver.FindElement(garmentElement, Locators.GarmentNameLabel).Text
                    };
                    if (Driver.ElementDisplayed(garmentElement, Locators.GarmentSizeLabel))
                    {
                        garment.Size = Driver.FindElement(garmentElement, Locators.GarmentSizeLabel).Text;
                    }
                    list.Add(garment);
                }
                return list.AsReadOnly();
            }
        }

        public class Locators
        {
            public static readonly By NameLabel = By.CssSelector("div:not([class='delivery-details'])>h2");
            public static readonly By EmailLabel = By.CssSelector("div:not([class='delivery-details'])>h2~p");
            public static readonly By EditPartyMemberLink = By.CssSelector("div:not([class='delivery-details'])>h2~a");
            public static readonly By RoleLabel = By.CssSelector("[class='role']>span");

            public static readonly By OutfitNameLabel = By.ClassName("summary-outfit-name");
            public static readonly By DeliveryAddressLabel = By.CssSelector("[class='delivery-wrap delivery']>div>[class*='delivery-details-address']");
            public static readonly By DeliveryDateLabel = By.CssSelector("[class='delivery-wrap delivery']>div>[class='delivery-date']");
            public static readonly By ReturnAddressLabel = By.CssSelector("[class='delivery-wrap return']>div>[class*='delivery-details-address']");
            public static readonly By ReturnDateLabel = By.CssSelector("[class='delivery-wrap return']>div>[class='delivery-date']");

            public static readonly By AllGarments = By.ClassName("garment");
            public static readonly By GarmentNameLabel = By.CssSelector("[class='garment-label-orderSummary']>label");
            public static readonly By GarmentSizeLabel = By.CssSelector("[class='selected-size-orderSummary']");
        }

        public class Garment
        {
            public string Name { get; set; }
            public string Size { get; set; }
        }
    }
}
