using System;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace XedoModel.Pages.PaymentProcess
{
    public class PaymentOptionsPage : PageBase
    {
        public PaymentOptionsPage(TestSettings testSettings) : base(testSettings)
        {
        }

        public string GroomTotalDue
        {
            get { return Driver.FindElement(Locators.GroomTotalDue).Text; }
        }

        public override bool IsLoaded()
        {
            return Driver.ElementDisplayed(Locators.Content);
        }
        
        public class Locators
        {
            public static readonly By Content = By.XPath("//*[contains(@class, 'content-section-holder')]");
            public static readonly By GroomTotalDue = By.XPath("//*[@class='total-amount'][1]");
        }
    }
}
