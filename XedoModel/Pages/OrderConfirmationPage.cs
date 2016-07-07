using System;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace XedoModel.Pages
{
    class OrderConfirmationPage : PageBase
    {
        public OrderConfirmationPage(TestSettings testSettings) : base(testSettings)
        {
        }

        public IWebElement SageContainer
        {
            get { return Driver.FindElement(Locators.SageContainer); }
        }

        public IWebElement OrderSuccessIcon
        {
            get { return Driver.FindElement(Locators.OrderSuccessIcon); }
        }

        public IWebElement OrderFailureIcon
        {
            get { return Driver.FindElement(Locators.OrderFailureIcon); }
        }

        public IWebElement OrderNumberLabel
        {
            get { return Driver.FindElement(Locators.OrderNumberLabel); }
        }

        public bool Confirmed
        {
            get { return Driver.ElementDisplayed(Locators.OrderSuccessIcon); }
        }

        public override bool IsLoaded()
        {
            return Driver.ElementDisplayed(Locators.SageContainer);
        }

        public override void SetupState()
        {
            throw new NotImplementedException();
        }

        public class Locators
        {
            public static By SageContainer = By.XPath("//*[@class='sage-confirmation-holder']");
            public static By OrderSuccessIcon = By.XPath("//div[@class='sage-status-holder confirmed']");
            public static By OrderFailureIcon = By.XPath("//div[@class='sage-status-holder denied']");
            public static By OrderNumberLabel = By.XPath("//*[@class='sage-order-number-text']");
        }
    }
}
