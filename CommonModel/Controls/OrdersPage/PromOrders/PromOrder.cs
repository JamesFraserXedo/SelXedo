using CommonModel.Controls.OrdersPage.BaseOrders;
using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.OrdersPage.PromOrders
{
    public class PromOrder : BaseOrder
    {
        public PromOrder(TestSettings testSettings, IWebElement container) : base(testSettings, container)
        {
        }

        protected IWebElement EventDateLabel
        {
            get { return Driver.FindElement(Container, Locators.ThirdColumnCell); }
        }

        protected Button ViewOrderButton
        {
            get { return new Button(Driver.FindElement(Container, Locators.ViewOrderButton)); }
        }

        public string EventDate
        {
            get { return EventDateLabel.Text; }
        }

        public new class Locators : BaseOrder.Locators
        {
            public static readonly By ViewOrderButton = By.CssSelector("td:nth-of-type(4)>a");
        }

    }
}
