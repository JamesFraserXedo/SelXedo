using CommonModel.Controls.OrdersPage.BaseOrders;
using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.OrdersPage.PreviousOrders
{
    public class PreviousOrder : BaseOrder
    {
        public PreviousOrder(TestSettings testSettings, IWebElement container) : base(testSettings, container)
        {
        }

        protected IWebElement WeddingPartyLabel
        {
            get { return Driver.FindElement(Container, Locators.ThirdColumnCell); }
        }

        protected IWebElement WeddingDateLabel
        {
            get { return Driver.FindElement(Container, Locators.FourthColumnCell); }
        }

        public string WeddingParty
        {
            get { return WeddingPartyLabel.Text; }
        }

        public string WeddingDate
        {
            get { return WeddingDateLabel.Text; }
        }
    }
}
