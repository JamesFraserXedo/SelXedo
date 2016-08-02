using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Pages
{
    public abstract class BaseTryOnReviewPage : PageBase
    {
        protected BaseTryOnReviewPage(TestSettings testSettings) : base(testSettings)
        {
        }

        public override bool IsLoaded()
        {
            return Driver.ElementDisplayed(Locators.ConfirmTryOnButton);
        }

        public string UserName
        {
            get
            {
                return Driver.FindElement(Locators.UsersNameLabel).Text.Split(new[] {Environment.NewLine}, StringSplitOptions.None)[1];
            }
        }

        public string UserRole
        {
            get
            {
                return Driver.FindElement(Locators.UsersRoleLabel).Text.Split(new[] { Environment.NewLine }, StringSplitOptions.None)[1];
            }
        }

        public string UserEmail
        {
            get
            {
                return Driver.FindElement(Locators.UsersEmailLabel).Text.Split(new[] { Environment.NewLine }, StringSplitOptions.None)[1];
            }
        }

        public string UserNumber
        {
            get
            {
                return Driver.FindElement(Locators.UsersNumberLabel).Text.Split(new[] { Environment.NewLine }, StringSplitOptions.None)[1];
            }
        }

        public ReadOnlyCollection<string> OutfitItemNames
        {
            get
            {
                var elements = Driver.FindElements(Locators.OutfitItemNameLabels);
                return elements.Select(e => e.Text).ToList().AsReadOnly();
            }
        }

        public ReadOnlyCollection<string> OutfitItemSizes
        {
            get
            {
                var elements = Driver.FindElements(Locators.OutfitItemSizeLabels);
                return elements.Select(e => e.Text).ToList().AsReadOnly();
            }
        }

        public Link EditSizesLink
        {
            get { return new Link(Driver.FindElement(Locators.EditSizesLink)); }
        }

        public ReadOnlyCollection<string> ItemsNotAvailable
        {
            get
            {
                var elements = Driver.FindElements(Locators.ItemsNotAvailable);
                return elements.Select(e => e.Text).ToList().AsReadOnly();
            }
        }

        public string DeliveryDay
        {
            get { return Driver.FindElement(Locators.DeliveryDayLabel).Text; }
        }

        public string DeliveryDate
        {
            get { return Driver.FindElement(Locators.DeliveryDateLabel).Text; }
        }

        public Link ChangeDeliveryDateLink
        {
            get { return new Link(Driver.FindElement(Locators.ChangeDeliveryDateLink)); }
        }

        public string ReturnByDay
        {
            get { return Driver.FindElement(Locators.ReturnByDayLabel).Text; }
        }

        public string ReturnDate
        {
            get { return Driver.FindElement(Locators.ReturnDateLabel).Text; }
        }

        public string AddressLine1
        {
            get { return Driver.FindElement(Locators.AddressLine1).Text; }
        }

        public string AddressLine2
        {
            get { return Driver.FindElement(Locators.AddressLine2).Text; }
        }

        public string AddressLine3
        {
            get { return Driver.FindElement(Locators.AddressLine3).Text; }
        }

        public string AddressLine4
        {
            get { return Driver.FindElement(Locators.AddressLine4).Text; }
        }

        public string AddressLinePostCode
        {
            get { return Driver.FindElement(Locators.AddressLinePostCode).Text; }
        }

        public string Cost
        {
            get { return Driver.FindElement(Locators.CostLabel).Text; }
        }

        public Button ConfirmTryOnButton
        {
            get { return new Button(Driver.FindElement(Locators.ConfirmTryOnButton)); }
        }

        public Button BackButton
        {
            get { return new Button(Driver.FindElement(Locators.BackButton)); }
        }

        public class Locators
        {
            public static readonly By UsersNameLabel = By.CssSelector(".tryon-details-summary-holder>p:nth-of-type(1)");
            public static readonly By UsersRoleLabel = By.CssSelector(".tryon-details-summary-holder>p:nth-of-type(2)");
            public static readonly By UsersEmailLabel = By.CssSelector(".tryon-details-summary-holder>p:nth-of-type(3)");
            public static readonly By UsersNumberLabel = By.CssSelector(".tryon-details-summary-holder>p:nth-of-type(4)");

            public static readonly By OutfitItemNameLabels = By.CssSelector(".garment-label-tryonSummary>label");
            public static readonly By OutfitItemSizeLabels = By.CssSelector(".selected-size-tryonSummary");

            public static readonly By EditSizesLink = By.CssSelector("[class='link primary-cta']");
            public static readonly By ItemsNotAvailable = By.CssSelector("[class='unavailable-wearer-item']");

            public static readonly By DeliveryDayLabel = By.CssSelector(".tryon-date-day:nth-of-type(1)");
            public static readonly By DeliveryDateLabel = By.CssSelector(".tryon-date-fulldate:nth-of-type(2)");
            public static readonly By ChangeDeliveryDateLink = By.CssSelector("[class='link.primary-cta.change-date']");

            public static readonly By ReturnByDayLabel = By.CssSelector(".tryon-date-day:nth-of-type(4)");
            public static readonly By ReturnDateLabel = By.CssSelector(".tryon-date-fulldate:nth-of-type(5)");

            public static readonly By AddressLine1 = By.Id("SelectedAddress_AddressModel_Address1");
            public static readonly By AddressLine2 = By.Id("SelectedAddress_AddressModel_Address2");
            public static readonly By AddressLine3 = By.Id("SelectedAddress_AddressModel_Address3");
            public static readonly By AddressLine4 = By.Id("SelectedAddress_AddressModel_Address4");
            public static readonly By AddressLinePostCode = By.Id("SelectedAddress_AddressModel_Postcode");

            public static readonly By CostLabel = By.CssSelector("[class='total-price-amount']");
            public static readonly By ConfirmTryOnButton = By.Id("btn-confirm-submit");
            public static readonly By BackButton = By.Id("btn-try-on-prev-confirmation");
        }
    }
}
