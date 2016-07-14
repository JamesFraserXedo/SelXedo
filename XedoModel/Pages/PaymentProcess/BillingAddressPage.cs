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

        public IWebElement ConfirmListedAddressButton
        {
            get { return Driver.FindElement(Container, Locators.ConfirmListedAddressButton); }
        }

        public InputBox Address1InputBox
        {
            get { return new InputBox(Driver.FindElement(Container, Locators.Address1InputBox)); }
        }

        public InputBox StateInputBox
        {
            get { return new InputBox(Driver.FindElement(Container, Locators.StateInputBox)); }
        }

        public InputBox ZipInputBox
        {
            get { return new InputBox(Driver.FindElement(Container, Locators.ZipInputBox)); }
        }

        public IWebElement ConfirmEnteredAddressButton
        {
            get { return Driver.FindElement(Container, Locators.ConfirmEnteredAddressButton); }
        }

        public InputBox ContactNumberInputBox
        {
            get { return new InputBox(Driver.FindElement(Container, Locators.ContactNumberInputBox)); }
        }

        public IWebElement PaymentOptionsButton
        {
            get { return Driver.FindElement(Container, Locators.PaymentOptionsButton); }
        }

        public override bool IsLoaded()
        {
            return Driver.ElementDisplayed(Locators.Container);
        }
        
        public class Locators
        {
            public static readonly By Container = By.XPath("//*[@class='content-section-holder']");
            public static readonly By ConfirmListedAddressButton = By.Id("confirm-address");

            public static readonly By Address1InputBox = By.Id("address1");
            public static readonly By StateInputBox = By.Id("address4");
            public static readonly By ZipInputBox = By.Id("postcode");
            public static readonly By ConfirmEnteredAddressButton = By.Id("confirm-manual-address");

            public static readonly By ContactNumberInputBox = By.Id("ContactNumber");
            public static readonly By PaymentOptionsButton = By.Id("btn-outfit-delivery-next");
        }
    }
}
