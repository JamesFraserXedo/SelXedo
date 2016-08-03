using CommonModel.Controls.OrdersPage.BaseOrders;
using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.OrdersPage.OpenOrders
{
    public class OpenOrder : BaseFullOrder
    {
        public OpenOrder(TestSettings testSettings, IWebElement container) : base(testSettings, container)
        {
        }

        public Button TrackingButton
        {
            get { return new Button(Driver.FindElement(Container, Locators.TrackingButton)); }
        }

        public new class Locators : BaseFullOrder.Locators
        {
            public static readonly By TrackingButton = By.CssSelector("td:nth-of-type(5)>a");
        }
    }
}
