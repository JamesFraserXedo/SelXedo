using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace CommonModel.Controls.Common.Cookies
{
    public class CookiesDirective : ControlBase
    {
        public CookiesDirective(TestSettings testSettings) : base(testSettings)
        {
        }

        public IWebElement Container
        {
            get { return Driver.FindElement(Locators.Container); }
        }

        public Button DismissButton
        {
            get { return new Button(Driver.FindElement(Container, Locators.DismissButton)); }
        }

        public void DismissIfPresent()
        {
            
            if (Driver.ElementDisplayed(Locators.Container))
            {
                // ToDo: Kindy hacky to wait until it's stopped scrolling using CSS...
                var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
                wait.Until(d => d.FindElement(Locators.Container).GetCssValue("bottom") == "0px");
                Driver.WaitForElementToAppear(Locators.DismissButton);
                DismissButton.Click();
            }
        }

        public class Locators
        {
            public static readonly By Container = By.Id("cookiesdirective");
            public static readonly By DismissButton = By.Id("impliedsubmit");
        }
    }
}
