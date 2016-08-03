using CommonModel.Controls.OrdersPage.BaseOrders;
using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.OrdersPage.TryOnOrders
{
    public class TryOnOrder : BaseTryOnOrder
    {
        public TryOnOrder(TestSettings testSettings, IWebElement container) : base(testSettings, container)
        {
        }

        public Button TrackingButton
        {
            get { return new Button(Driver.FindElement(Container, Locators.TrackingButton)); }
        }

        public new class Locators : BaseTryOnOrder.Locators
        {
            public static readonly By TrackingButton = By.CssSelector("td:nth-of-type(5)>a");
        }
    }
}
