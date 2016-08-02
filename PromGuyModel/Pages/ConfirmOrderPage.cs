using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;
using PromGuyModel.Controls.Billing;

namespace PromGuyModel.Pages
{
    public class ConfirmOrderPage : PageBase
    {
        public ConfirmOrderPage(TestSettings testSettings) : base(testSettings)
        {
        }

        public override bool IsLoaded()
        {
            return Driver.ElementDisplayed(Locators.TotalLabel);
        }

        public ConfirmationMethodPanel ConfirmationMethodPanel
        {
            get { return new ConfirmationMethodPanel(TestSettings); }
        }

        public BillingAddressPanel BillingAddressPanel
        {
            get { return new BillingAddressPanel(TestSettings); }
        }

        public Button CancelButton
        {
            get { return new Button(Driver.FindElement(Locators.CancelButton)); }
        }

        public Button ConfirmButton
        {
            get { return new Button(Driver.FindElement(Locators.ConfirmButton)); }
        }

        private IWebElement TotalLabel
        {
            get { return Driver.FindElement(Locators.TotalLabel); }
        }

        public string Total
        {
            get { return TotalLabel.Text.Replace("Total", "").Trim(); }
        }

        public class Locators
        {
            public static readonly By CancelButton = By.Id("pay-back");
            public static readonly By ConfirmButton = By.CssSelector("[data-at='btn-pay-submit']");
            public static readonly By TotalLabel = By.CssSelector("[class='form-inner-totaltext']");
        }
    }
}
