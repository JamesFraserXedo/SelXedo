using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonModel.Controls.OrdersPage.DraftOrders;
using CommonModel.Controls.OrdersPage.DraftTryOnOrders;
using CommonModel.Controls.OrdersPage.OpenOrders;
using CommonModel.Controls.OrdersPage.PreviousOrders;
using CommonModel.Controls.OrdersPage.TryOnOrders;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Pages
{
    public abstract class BaseOrdersPage : PageBase
    {
        protected BaseOrdersPage(TestSettings testSettings) : base(testSettings)
        {
        }

        public override bool IsLoaded()
        {
            return Driver.ElementDisplayed(Locators.PageTitle);
        }

        public IReadOnlyCollection<OpenOrder> OpenOrders
        {
            get
            {
                var elements = Driver.FindElements(Locators.OpenOrders);
                return elements.Select(e => new OpenOrder(TestSettings, e)).ToList().AsReadOnly();
            }
        }

        public IReadOnlyCollection<DraftOrder> DraftOrders
        {
            get
            {
                var elements = Driver.FindElements(Locators.DraftOrders);
                return elements.Select(e => new DraftOrder(TestSettings, e)).ToList().AsReadOnly();
            }
        }

        public IReadOnlyCollection<DraftTryOnOrder> DraftTryOnOrders
        {
            get
            {
                var elements = Driver.FindElements(Locators.DraftTryOnOrders);
                return elements.Select(e => new DraftTryOnOrder(TestSettings, e)).ToList().AsReadOnly();
            }
        }

        public IReadOnlyCollection<TryOnOrder> TryOnOrders
        {
            get
            {
                var elements = Driver.FindElements(Locators.TryOnOrders);
                return elements.Select(e => new TryOnOrder(TestSettings, e)).ToList().AsReadOnly();
            }
        }

        public IReadOnlyCollection<PreviousOrder> PreviousOrders
        {
            get
            {
                var elements = Driver.FindElements(Locators.PreviousOrders);
                return elements.Select(e => new PreviousOrder(TestSettings, e)).ToList().AsReadOnly();
            }
        } 

        public class Locators
        {
            public static readonly By PageTitle = By.CssSelector("[class='page-intro-header']");
            
            //ToDo Improve hooks to use css tags
            public static readonly By OpenOrders = By.XPath("//h2[text()='Open Orders']/..//tr[@class='orderSummary']");
            public static readonly By DraftOrders = By.XPath("//h2[text()='Draft Orders']/..//tr[@class='orderSummary']");
            public static readonly By DraftTryOnOrders = By.XPath("//h2[text()='Draft Try On Orders']/..//tr[@class='orderSummary']");
            public static readonly By TryOnOrders = By.XPath("//h2[text()='Try On Orders']/..//tr[@class='orderSummary']");
            public static readonly By PreviousOrders = By.XPath("//h2[text()='Previous Orders']/..//tr[@class='orderSummary']");
        }
    }
}
