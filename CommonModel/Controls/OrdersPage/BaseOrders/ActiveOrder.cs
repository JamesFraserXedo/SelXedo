using Core.CustomElements;
using Core.Model.SupportTools;
using Core.Model.TestObjects.Bases;
using OpenQA.Selenium;

namespace CommonModel.Controls.OrdersPage.BaseOrders
{
    public abstract class ActiveOrder : BaseOrder
    {
        protected ActiveOrder(TestSettings testSettings, IWebElement container) : base(testSettings, container)
        {
        }

        public Button GoToOrderButton
        {
            get { return new Button(Driver.FindElement(Container, Locators.GoToOrderButton)); }
        }

        public Button DeleteOrderButton
        {
            get { return new Button(Driver.FindElement(Container, Locators.DeleteOrderButton)); }
        }

        public new class Locators : BaseOrder.Locators
        {
            public static readonly By GoToOrderButton = By.CssSelector("td>a:nth-of-type(1)");
            public static readonly By DeleteOrderButton = By.CssSelector("td>a:nth-of-type(2)");
        }
    }
}
