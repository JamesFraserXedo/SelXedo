using CommonModel.Controls.OrdersPage.BaseOrders;
using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.OrdersPage.DraftOrders
{
    public class DraftOrder : BaseFullOrder
    {
        public DraftOrder(TestSettings testSettings, IWebElement container) : base(testSettings, container)
        {
        }
    }
}
