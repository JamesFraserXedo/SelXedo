using System;
using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace XedoModel.Pages.PaymentProcess
{
    public class BillingAddressPage : PageBase
    {
        public BillingAddressPage(TestSettings testSettings) : base(testSettings)
        {
        }

        public IWebElement Container
        {
            get { return Driver.FindElement(Locators.Container); }
        }

        public Button ConfirmListedAddressButton
        {
            get { return new Button(Driver.FindElement(Container, Locators.ConfirmListedAddressButton)); }
        }

        protected Inputbox Address1Inputbox
        {
            get { return new Inputbox(Driver.FindElement(Container, Locators.Address1Inputbox)); }
        }

        protected Inputbox StateInputbox
        {
            get { return new Inputbox(Driver.FindElement(Container, Locators.StateInputbox)); }
        }

        protected Inputbox ZipInputbox
        {
            get { return new Inputbox(Driver.FindElement(Container, Locators.ZipInputbox)); }
        }

        public Button ConfirmEnteredAddressButton
        {
            get { return new Button(Driver.FindElement(Container, Locators.ConfirmEnteredAddressButton)); }
        }

        protected Inputbox ContactNumberInputbox
        {
            get { return new Inputbox(Driver.FindElement(Container, Locators.ContactNumberInputbox)); }
        }

        public Button PaymentOptionsButton
        {
            get { return new Button(Driver.FindElement(Container, Locators.PaymentOptionsButton)); }
        }

        public string Address1
        {
            get { return Address1Inputbox.Text; }
            set { Address1Inputbox.SendKeys(value); }
        }

        public string State
        {
            get { return StateInputbox.Text; }
            set { StateInputbox.SendKeys(value); }
        }

        public string Zipcode
        {
            get { return ZipInputbox.Text; }
            set { ZipInputbox.SendKeys(value); }
        }

        public string ContactNumber
        {
            get { return ContactNumberInputbox.Text; }
            set { ContactNumberInputbox.SendKeys(value); }
        }



        public override bool IsLoaded()
        {
            return Driver.ElementDisplayed(Locators.Container);
        }
        
        public class Locators
        {
            public static readonly By Container = By.XPath("//*[@class='content-section-holder']");
            public static readonly By ConfirmListedAddressButton = By.Id("confirm-address");

            public static readonly By Address1Inputbox = By.Id("address1");
            public static readonly By StateInputbox = By.Id("address4");
            public static readonly By ZipInputbox = By.Id("postcode");
            public static readonly By ConfirmEnteredAddressButton = By.Id("confirm-manual-address");

            public static readonly By ContactNumberInputbox = By.Id("ContactNumber");
            public static readonly By PaymentOptionsButton = By.Id("btn-outfit-delivery-next");
        }
    }
}
