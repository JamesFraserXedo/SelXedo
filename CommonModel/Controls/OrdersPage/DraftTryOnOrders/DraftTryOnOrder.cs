using CommonModel.Controls.OrdersPage.BaseOrders;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.OrdersPage.DraftTryOnOrders
{
    public class DraftTryOnOrder : BaseFullOrder
    {
        public DraftTryOnOrder(TestSettings testSettings, IWebElement container) : base(testSettings, container)
        {
        }
    }
}
