using System;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace XedoModel.Pages.PaymentProcess
{
    public class SelectWeddingDatePage : PageBase
    {
        public SelectWeddingDatePage(TestSettings testSettings) : base(testSettings)
        {
        }

        public IWebElement ConfirmWeddingDateButton
        {
            get { return Driver.FindElement(Locators.ConfirmWeddingDateButton); }
        }

        public IWebElement ContinueButton
        {
            get { return Driver.FindElement(Locators.ContinueButton); }
        }

        public override bool IsLoaded()
        {
            return Driver.ElementDisplayed(Locators.MainContent);
        }

        public void ConfirmWeddingDate()
        {
            ConfirmWeddingDateButton.Click();
        }

        public void Continue()
        {
            ContinueButton.Click();
        }

        public class Locators
        {
            public static readonly By ConfirmWeddingDateButton = By.Id("confirm-wedding-date");
            public static readonly By ContinueButton = By.Id("btn-wedding-date-next");
            public static readonly By MainContent = By.XPath("//*[@class='content-section-holder']");
        }
    }
}
