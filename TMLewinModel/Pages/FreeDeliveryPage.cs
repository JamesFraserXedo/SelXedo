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
using TMLewinModel.Controls.HomePage;

namespace TMLewinModel.Pages
{
    public class FreeDeliveryPage : PageBase
    {
        public FreeDeliveryPage(TestSettings testSettings) : base(testSettings)
        {
        }

        public override bool IsLoaded()
        {
            throw new NotImplementedException();
        }

        public Button GetStartedButton
        {
            get { return new Button(Driver.FindElement(Locators.GetStartedButton)); }
        }
        
        public ReadOnlyCollection<HomePageFeature> Features
        {
            get
            {
                var elements = Driver.FindElements(Locators.Features);
                return elements.Select(e => new HomePageFeature(TestSettings, e)).ToList().AsReadOnly();
            }
        }
        
        public class Locators
        {
            public static readonly By Features = By.XPath("//*[contains(@class, 'homepage-feature-col')]");
            public static readonly By GetStartedButton = By.CssSelector("[class='text-center']>a");
        }
    }
}
