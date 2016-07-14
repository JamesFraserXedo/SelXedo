using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;
using TMLewinModel.Controls.PriceListPage;

namespace TMLewinModel.Pages
{
    public class PriceListPage : PageBase
    {
        public PriceListPage(TestSettings testSettings) : base(testSettings)
        {
        }

        public override bool IsLoaded()
        {
            throw new NotImplementedException();
        }

        public ReadOnlyCollection<PriceListItem> PriceListItems
        {
            get
            {
                var elements = Driver.FindElements(Locators.PriceListItems);
                return elements.Select(e => new PriceListItem(TestSettings, e)).ToList().AsReadOnly();
            }
        }

        public ReadOnlyCollection<IWebElement> FinishingTouchLabels
        {
            get { return Driver.FindElements(Locators.FinishingTouchLabels); }
        } 

        public class Locators
        {
            public static readonly By PriceListItems = By.ClassName("outfit-pricelist-inner");
            public static readonly By FinishingTouchLabels = By.ClassName("finishing-touches-item");

        }
    }
}
